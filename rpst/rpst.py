import argparse
from datetime import datetime

import requests
from glyphoji import glyph
from rich.tree import Tree
from rich import print as xprint

from .utils import convert_timestamp_to_datetime, write_post_data


def create_post_branch(post: dict, keyword: str, tree: Tree, args: argparse) -> Tree:
    """
    This function extracts relevant data from a Reddit post and adds it in a tree branch structure,
    followed by the post's selftext.

    :param post: A dictionary containing the data of a Reddit post.
    :param keyword: The keyword that is used to find posts, in his case gets uses as the filename.
    :param tree: Tree where the post branch will be added.
    :param args: A namespace object from argparse.
    :returns: The main tree with added post branches.
    """
    # Define the data to extract from the post.
    post_data = {
        # "Author": post["data"]["author"],
        f"{glyph.id_button} ID": post["data"]["id"],
        f"{glyph.people_hugging} Subreddit": post["data"]["subreddit_name_prefixed"],
        f"{glyph.face_with_peeking_eye} Visibility": post["data"]["subreddit_type"],
        f"{glyph.framed_picture} Thumbnail": post["data"]["thumbnail"],
        f"{glyph.white_question_mark} Gilded": post["data"]["gilded"],
        f"{glyph.up_arrow} Upvotes": post["data"]["ups"],
        f"{glyph.chart_increasing} Upvote ratio": post["data"]["upvote_ratio"],
        f"{glyph.down_arrow} Downvotes": post["data"]["downs"],
        f"{glyph.trophy} Awards": post["data"]["total_awards_received"],
        f"{glyph.trophy} Top award": post["data"]["top_awarded_type"],
        f"{glyph.no_one_under_eighteen} Is NSFW?": post["data"]["over_18"],
        f"{glyph.left_arrow_curving_right} Is crosspostable?": post["data"][
            "is_crosspostable"
        ],
        f"{glyph.bar_chart} Score": post["data"]["score"],
        f"{glyph.card_file_box} Category": post["data"]["category"],
        f"{glyph.globe_with_meridians} Domain": post["data"]["domain"],
        f"{glyph.calendar} Posted on": convert_timestamp_to_datetime(
            post["data"]["created"]
        ),
        f"{glyph.calendar} Approved at": post["data"]["approved_at_utc"],
        f"{glyph.bust_in_silhouette} Approved by": post["data"]["approved_by"],
    }

    # Add the post's branch to the main tree.
    post_branch = tree.add(f"{glyph.scroll} {post['data']['title']}")

    # Add each piece of extracted data as a branch of the post_branch.
    for post_key, post_value in post_data.items():
        post_branch.add(f"{post_key}: {post_value}", style="dim")

    # This ensures that the post's selftext is also added to the written json/csv file.
    post_data[f"{glyph.clipboard} Text"] = post["data"]["selftext"]
    write_post_data(
        filename=keyword, post_data=post_data, tree_branch=post_branch, args=args
    )
    post_branch.add(post["data"]["selftext"], style="italic")

    return tree


def get_posts(args: argparse):
    """
    Scrapes a given subreddit for posts that contain a specified keyword.
    The search is limited by the number of posts and timeframe specified.

    :param args: Namespace object from argparse.

    Expected Object Attributes
    --------------------------
        - keyword: The keyword to search for in the posts.
        - subreddit: The subreddit to scrape.
        - listing: The type of posts to scrape. This could be 'hot', 'new', etc.
        - timeframe: The timeframe from which to scrape posts. This could be 'day', 'week', etc.
        - limit: The maximum number of posts to scrape.
        - json: If specified, all found posts will be written to a json file.
    """
    keyword = args.keyword
    subreddit = args.subreddit
    listing = args.listing
    timeframe = args.timeframe
    limit = args.limit

    # Create main result tree.
    main_tree = Tree(
        f"[bold]{glyph.calendar} {datetime.now()}[/]", guide_style="bold bright_blue"
    )

    # Start a new session
    session = requests.session()
    # Set the User-Agent to mimic a Safari browser on a Mac.
    session.headers = {
        "User-Agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, "
        "like Gecko) Version/14.1.1 Safari/605.1.15"
    }

    # Send a GET request to the specified subreddit and listing,
    # limiting the response by the specified limit and timeframe.
    response = session.get(
        f"https://reddit.com/r/{subreddit}/{listing}"
        f".json?limit={limit}&t={timeframe}"
    ).json()

    # Initialize a counter for the number of posts found that contain the keyword.
    found_posts = 0

    # Loop through each post in the response
    for post_index, post in enumerate(response["data"]["children"], start=1):
        # If the keyword is found in the post's selftext or title, increment the counter and process the post.
        if (
            keyword.lower() in post["data"]["selftext"]
            or keyword.lower() in post["data"]["title"]
        ):
            # Create a branch for found post(s) and show post index and post author as the title
            found_tree = main_tree.add(
                f"{glyph.bust_in_silhouette} #{post_index} by [bold]@{post['data']['author']}[/]"
            )
            found_posts += 1
            create_post_branch(post=post, keyword=keyword, tree=found_tree, args=args)

    # Log the number of posts in which the keyword was found
    main_tree.add(
        f"{glyph.check_mark_button} Keyword ('{keyword}') was found in "
        f"{found_posts}/{len(response['data']['children'])} {listing} posts from r/{subreddit}."
    )
    xprint(main_tree)
