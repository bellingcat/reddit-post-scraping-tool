import os
import csv
import json
import logging
import argparse
from datetime import datetime

import requests
from glyphoji import glyph
from rich.tree import Tree
from rich import print as xprint
from rich.markdown import Markdown
from rich.logging import RichHandler


def convert_timestamp_to_datetime(timestamp: int) -> str:
    """
    Converts a Unix timestamp to a formatted datetime string.

    :param timestamp: The Unix timestamp to be converted.
    :return: A formatted datetime string in the format "dd MMMM yyyy, hh:mm:ssAM/PM".
    """
    utc_from_timestamp = datetime.utcfromtimestamp(timestamp)
    datetime_object = utc_from_timestamp.strftime("%d %B %Y, %I:%M:%S%p")
    return datetime_object


def create_parser():
    """
    Creates and configures an argument parser for the command line arguments.

    :return: A configured argparse.ArgumentParser object ready to parse the command line arguments.
    """
    parser = argparse.ArgumentParser(
        description="RPST (Reddit Post Scraping Tool)  —by Richard Mwewa | https://about.me/rly0nheart",
        epilog="Given a subreddit name and a keyword, "
        "RPST returns all top (by default) posts that contain the specified keyword.",
    )

    parser.add_argument(
        "-k", "--keyword", help="The keyword to search for in the posts.", required=True
    )
    parser.add_argument(
        "-s", "--subreddit", help="The subreddit to scrape.", required=True
    )
    parser.add_argument(
        "-c",
        "--limit",
        help="The maximum number of posts to scrape (1-100). (default: %(default)s)",
        default=10,
        type=int,
        choices=range(
            1, 101
        ),  # This enforces that the limit must be between 1 and 100 inclusive.
    )
    parser.add_argument(
        "-l",
        "--listing",
        default="top",
        const="top",
        nargs="?",
        choices=["controversial", "hot", "best", "new", "rising"],
        help="The type of posts to scrape (default: %(default)s)",
    )
    parser.add_argument(
        "-t",
        "--timeframe",
        default="all",
        const="all",
        nargs="?",
        choices=["hour", "day", "week", "month", "year", "all"],
        help="The timeframe from which to scrape posts (default: %(default)s)",
    )
    parser.add_argument(
        "--json",
        help="Write all found posts to a json file.",
        action="store_true",
    )
    parser.add_argument(
        "--csv",
        help="Write all found posts to a csv file.",
        action="store_true",
    )
    parser.add_argument(
        "-d",
        "--debug",
        help="run rpst in debug mode (show network logs)",
        action="store_true",
    )

    return parser


def check_updates(version_tag: str):
    """
    This function checks if there's a new release of a project on GitHub. If there is, it logs an
    information message and prints the release notes.

    :param version_tag: A string representing the current version of the project.
    """

    # Make a GET request to the GitHub API to get the latest release of the project.
    response = requests.get(
        "https://api.github.com/repos/bellingcat/reddit-post-scraping-tool/releases/latest"
    ).json()

    # Check if the latest release's tag matches the current version tag.
    if response["tag_name"] != version_tag:
        # If not, convert the release notes from Markdown to HTML.
        raw_release_notes = response["body"]

        # Log an info message about the new release.
        xprint(
            f"{glyph.up_arrow} A new release of RPST is available ({response['tag_name']}). "
            f"Run 'pip install --upgrade reddit-post-scraping-tool' to get the updates."
        )

        # Print the release notes.
        xprint(Markdown(raw_release_notes))


def set_loglevel(args: argparse) -> logging.getLogger:
    """
    Configures the logging level based on the provided arguments.

    If `args.debug` is True, the logging level is set to "NOTSET," allowing all log messages to be displayed.
    Otherwise, the logging level is set to "INFO," and only informational and higher-severity messages are displayed.

    The function also configures a RichHandler for formatting the log messages,
     including a specific time format and hiding the log level.

    :param args: A namespace object from argparse containing the debugging option (args.debug).
    :return: A logger object associated with the name "rich."
    """
    if args.debug:
        logging.basicConfig(
            level="NOTSET",
            format="%(message)s",
            handlers=[
                RichHandler(
                    markup=True, log_time_format="[%H:%M:%S%p]", show_level=False
                )
            ],
        )
    else:
        logging.basicConfig(
            level="INFO",
            format="%(message)s",
            handlers=[
                RichHandler(
                    markup=True, log_time_format="[%H:%M:%S%p]", show_level=False
                )
            ],
        )

    return logging.getLogger("rich")


def write_post_data(post_data: dict, filename: str, args, tree_branch: Tree):
    """
    Writes post data to a specified JSON or CSV file based on the args provided, and updates
    the provided tree with the status.

    :param post_data: A dictionary containing post data.
    :param filename: The name of the file to which post data will be written.
    :param args: A namespace object from argparse containing the output format options (args.json or args.csv).
    :param tree_branch: A rich Tree object to which status information will be added.
    """
    home_directory = os.path.expanduser("~")

    if args.json:
        json_file_path = os.path.join(home_directory, f"{filename}.json")
        with open(json_file_path, "a", encoding="utf-8") as file:
            file.write(json.dumps(post_data, ensure_ascii=False))
            file.write("\n")  # Separate posts with newline
        tree_branch.add(
            f"{glyph.page_facing_up} JSON data successfully written/appended to file: "
            f"[italic][link file://{json_file_path}]{json_file_path}[/]"
        )
    else:
        tree_branch.add(
            f"{glyph.cross_mark_button}  JSON data writing operation was skipped. No changes made."
        )

    if args.csv:
        csv_file_path = os.path.join(home_directory, f"{filename}.csv")
        with open(csv_file_path, "a", newline="", encoding="utf-8") as csvfile:
            writer = csv.DictWriter(csvfile, fieldnames=post_data.keys())

            # Write headers if file is empty
            if csvfile.tell() == 0:
                writer.writeheader()

            writer.writerow(post_data)
        tree_branch.add(
            f"{glyph.page_facing_up} CSV data successfully written/appended to file: "
            f"[italic][link file://{csv_file_path}]{csv_file_path}[/]"
        )
    else:
        tree_branch.add(
            f"{glyph.cross_mark_button}  CSV data writing operation was skipped. No changes made."
        )
