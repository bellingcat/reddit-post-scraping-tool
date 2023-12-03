# +++++++++++++++++++++++++++++++++++++++++++++++++ #

import argparse
import csv
import json
import logging
import os
from datetime import datetime

from rich.logging import RichHandler
from rich.markdown import Markdown
from rich_argparse import RichHelpFormatter


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def timestamp_to_utc(timestamp: int) -> str:
    """
    Converts a Unix timestamp to a formatted datetime string.

    :param timestamp: The Unix timestamp to be converted.
    :return: A formatted datetime string in the format "dd MMMM yyyy, hh:mm:ssAM/PM".
    """
    utc_from_timestamp: datetime = datetime.utcfromtimestamp(timestamp)
    datetime_string: str = utc_from_timestamp.strftime("%d %B %Y, %I:%M:%S%p")
    return datetime_string


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def pathfinder(directories: list[str]):
    for directory in directories:
        os.makedirs(directory, exist_ok=True)


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def save_posts(
    filename: str,
    save_to_dir: str,
    posts: list,
    save_json: bool = False,
    save_csv: bool = False,
):
    posts_data: list = [post.__dict__ for post in posts]

    if save_json:
        json_path = os.path.join(os.path.join(save_to_dir, "json"), f"{filename}.json")
        with open(json_path, "w", encoding="utf-8") as json_file:
            json.dump(posts_data, json_file, indent=4)
        log.info(
            f"{os.path.getsize(json_file.name)} bytes written to [link file://{json_file.name}]{json_file.name}"
        )

    if save_csv:
        csv_path = os.path.join(os.path.join(save_to_dir, "csv"), f"{filename}.csv")
        with open(csv_path, "w", newline="", encoding="utf-8") as csv_file:
            writer = csv.writer(csv_file)
            if posts:
                writer.writerow(
                    posts_data[0].keys()
                )  # header from keys of the first item
                for post in posts:
                    writer.writerow(post.__dict__.values())
        log.info(
            f"{os.path.getsize(csv_file.name)} bytes written to [link file://{csv_file.name}]{csv_file.name}"
        )


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def create_parser():
    """
    Creates and configures an argument parser for the command line arguments.

    :return: A configured argparse.ArgumentParser object ready to parse the command line arguments.
    """
    from . import __version__, __description__, __epilog__

    parser = argparse.ArgumentParser(
        description=Markdown(__description__, style="argparse.text"),
        epilog=Markdown(__epilog__, style="argparse.text"),
        formatter_class=RichHelpFormatter,
    )

    parser.add_argument(
        "keyword",
        help="keyword to search for, in posts",
    )
    parser.add_argument("subreddit", help="subreddit to scrape")
    parser.add_argument(
        "-l",
        "--limit",
        help="maximum number of posts to scrape (default: %(default)s)",
        default=200,
        type=int,
    )
    parser.add_argument(
        "-ls",
        "--listing",
        default="top",
        const="top",
        nargs="?",
        choices=["best", "controversial", "hot", "new", "rising", "top"],
        help="listing of posts to scrape (default: %(default)s)",
    )
    parser.add_argument(
        "-t",
        "--timeframe",
        default="all",
        const="all",
        nargs="?",
        choices=["hour", "day", "week", "month", "year", "all"],
        help="timeframe from which to scrape posts (default: %(default)s)",
    )
    parser.add_argument(
        "-j",
        "--json",
        help="write found posts to a json file",
        action="store_true",
    )
    parser.add_argument(
        "-c",
        "--csv",
        help="write found posts to a csv file",
        action="store_true",
    )
    parser.add_argument(
        "-d",
        "--debug",
        help="(dev) run rpst in debug mode",
        action="store_true",
    )
    parser.add_argument("-v", "--version", action="version", version=__version__)

    return parser


# +++++++++++++++++++++++++++++++++++++++++++++++++ #


def set_loglevel(debug_mode: bool) -> logging.getLogger:
    """
    Configure and return a logging object with the specified log level.

    :param debug_mode: If True, the log level is set to "NOTSET". Otherwise, it is set to "INFO".
    :return: A logging object configured with the specified log level.
    """
    logging.basicConfig(
        level="DEBUG" if debug_mode else "INFO",
        format="%(message)s",
        handlers=[
            RichHandler(
                markup=True, log_time_format="%I:%M:%S%p", show_level=debug_mode
            )
        ],
    )
    return logging.getLogger("RPST (Reddit Post Scraping Tool)")


# +++++++++++++++++++++++++++++++++++++++++++++++++ #

args: argparse = create_parser().parse_args()
log: logging.getLogger = set_loglevel(debug_mode=args.debug)

# +++++++++++++++++++++++++++++++++++++++++++++++++ #
