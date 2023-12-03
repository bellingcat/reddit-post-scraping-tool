# +++++++++++++++++++++++++++++++++++++++++++++++++ #

import asyncio
import os
from datetime import datetime

from rich.pretty import pprint

from . import __version__, PROGRAM_DIRECTORY
from .base import find_posts
from .coreutils import args, log, save_posts, pathfinder


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def run():
    """Main entry point for rpst or rpst."""
    # ------------------------------------- #

    keyword: str = args.keyword
    subreddit: str = args.subreddit
    listing: str = args.listing
    limit: int = args.limit

    # ------------------------------------- #

    start_time = datetime.now()

    # ------------------------------------- #

    print(
        """
┳┓┏┓┏┓┏┳┓
┣┫┃┃┗┓ ┃ 
┛┗┣┛┗┛ ┻ """
    )

    # ------------------------------------- #

    try:
        log.info(
            f"[bold]RPST[/] {__version__} started at {start_time.strftime('%a %b %d %Y, %I:%M:%S%p')}..."
        )

        found_posts = asyncio.run(
            find_posts(
                keyword=keyword,
                subreddit=subreddit,
                listing=listing,
                timeframe=args.timeframe,
                limit=limit,
            ),
        )

        if found_posts:
            pprint(
                found_posts,
                expand_all=True,
            )
            log.info(
                f"'{subreddit}': Found {len(found_posts)}/{limit} {listing} posts containing the keyword ('{keyword}')"
            )
            if args.json or args.csv:
                target_dir: str = os.path.join(PROGRAM_DIRECTORY, subreddit)
                pathfinder(
                    directories=[
                        os.path.join(target_dir, "csv"),
                        os.path.join(target_dir, "json"),
                    ]
                )
                save_posts(
                    filename=keyword,
                    save_to_dir=target_dir,
                    posts=found_posts,
                    save_json=args.json,
                    save_csv=args.csv,
                )
        else:
            log.info(
                f"'r/{subreddit}': No {listing} posts found that contain the keyword ('{keyword}')"
            )

    except KeyboardInterrupt:
        log.warning("User interruption detected ([yellow]Ctrl+C[/])")
    except Exception as error:
        log.error(f"An error occurred: [red]{error}[/]")
    finally:
        log.info(f"Finished in {datetime.now() - start_time} seconds")

    # ------------------------------------- #


# +++++++++++++++++++++++++++++++++++++++++++++++++ #
