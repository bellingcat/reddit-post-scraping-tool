# +++++++++++++++++++++++++++++++++++++++++++++++++ #

from dataclasses import dataclass
from typing import List

import aiohttp

from .api import get_posts, get_updates
from .coreutils import timestamp_to_utc


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


@dataclass
class Post:
    id: str
    thumbnail: str
    title: str
    text: str
    author: str
    subreddit: str
    subreddit_id: str
    subreddit_type: str
    upvotes: int
    upvote_ratio: float
    downvotes: int
    gilded: int
    is_nsfw: bool
    is_shareable: bool
    is_edited: bool
    comments: int
    hide_from_bots: bool
    score: float
    domain: str
    permalink: str
    is_locked: bool
    is_archived: bool
    created_at: str
    raw_post: dict


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


async def find_posts(
    keyword: str,
    subreddit: str,
    listing: str,
    timeframe: str,
    limit: int,
) -> List[Post]:
    async with aiohttp.ClientSession() as session:
        found_posts_count: int = 0
        found_posts_list: list = []

        await get_updates(session=session)
        raw_posts: list = await get_posts(
            subreddit=subreddit,
            listing=listing,
            timeframe=timeframe,
            limit=limit,
            session=session,
        )
        for raw_post in raw_posts:
            post_data: dict = raw_post.get("data")

            if keyword.lower() in post_data.get(
                "selftext"
            ) or keyword.lower() in post_data.get("title"):
                found_posts_count += 1
                post = Post(
                    id=post_data.get("id"),
                    thumbnail=post_data.get("thumbnail"),
                    title=post_data.get("title"),
                    text=post_data.get("selftext"),
                    author=post_data.get("author"),
                    subreddit=post_data.get("subreddit"),
                    subreddit_id=post_data.get("subreddit_id"),
                    subreddit_type=post_data.get("subreddit_type"),
                    upvotes=post_data.get("ups"),
                    upvote_ratio=post_data.get("upvote_ratio"),
                    downvotes=post_data.get("downs"),
                    gilded=post_data.get("gilded"),
                    is_nsfw=post_data.get("over_18"),
                    is_shareable=post_data.get("is_reddit_media_domain"),
                    is_edited=post_data.get("edited"),
                    comments=post_data.get("num_comments"),
                    hide_from_bots=post_data.get("is_robot_indexable"),
                    score=post_data.get("score"),
                    domain=post_data.get("domain"),
                    permalink=post_data.get("permalink"),
                    is_locked=post_data.get("locked"),
                    is_archived=post_data.get("archived"),
                    created_at=timestamp_to_utc(timestamp=post_data.get("created_utc")),
                    raw_post=post_data,
                )
                found_posts_list.append(post)

        return found_posts_list


# +++++++++++++++++++++++++++++++++++++++++++++++++ #
