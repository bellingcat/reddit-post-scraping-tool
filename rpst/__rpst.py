import os
import json
import logging
import argparse
from datetime import datetime

import requests
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


def write_post_data(post_data: dict, filename: str) -> str:
    """
    Writes post data to a specified JSON file.

    :param post_data: A dictionary containing post data.
    :param filename: The name of the file to which post data will be written.
    :returns: A string representation of the file path.
    """
    home_directory = os.path.expanduser("~")
    file_path = os.path.join(home_directory, f"{filename}.json")

    # Write the data to a JSON file
    with open(file_path, "a") as file:
        file.write(json.dumps(post_data))
        file.write("\n")  # write a newline to separate posts.

    return file.name


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
        markdown_release_notes = Markdown(raw_release_notes)

        # Log an info message about the new release.
        log.info(
            f"A new release of RPST is available ({response['tag_name']}). "
            f"Run 'pip install --upgrade reddit-post-scraping-tool' to get the updates."
        )

        # Print the release notes.
        xprint(markdown_release_notes)


def create_post_branch(post: dict, keyword: str, output: bool, tree: Tree) -> Tree:
    """
    This function extracts relevant data from a Reddit post and adds it in a tree branch structure,
    followed by the post's selftext.

    :param post: A dictionary containing the data of a Reddit post.
    :param keyword: The keyword that is used to find posts, in his case gets uses as the filename.
    :param output: If specified, all found posts will be written to a json file.
    :param tree: Tree where the post branch will be added.
    :returns: The main tree with added post branches.
    """
    # Define the data to extract from the post.
    post_data = {
        # "Author": post["data"]["author"],
        "ID": post["data"]["id"],
        "Subreddit": post["data"]["subreddit_name_prefixed"],
        "Visibility": post["data"]["subreddit_type"],
        "Thumbnail": post["data"]["thumbnail"],
        "Gilded": post["data"]["gilded"],
        "Upvotes": post["data"]["ups"],
        "Upvote ratio": post["data"]["upvote_ratio"],
        "Downvotes": post["data"]["downs"],
        "Awards": post["data"]["total_awards_received"],
        "Top award": post["data"]["top_awarded_type"],
        "Is NSFW?": post["data"]["over_18"],
        "Is crosspostable?": post["data"]["is_crosspostable"],
        "Score": post["data"]["score"],
        "Category": post["data"]["category"],
        "Domain": post["data"]["domain"],
        "Posted on": convert_timestamp_to_datetime(post["data"]["created"]),
        "Approved at": post["data"]["approved_at_utc"],
        "Approved by": post["data"]["approved_by"],
    }

    # Add the post's branch to the main tree.
    post_branch = tree.add(f":scroll: {post['data']['title']}")

    # Add each piece of extracted data as a branch of the post_branch.
    for post_key, post_value in post_data.items():
        post_branch.add(f"{post_key}: {post_value}", style="dim")

    # If -j/--json is passed, write found posts to a json file.
    if output:
        # This ensures that the post's selftext is also added to the written json file.
        post_data["Text"] = post["data"]["selftext"]
        output_file = write_post_data(filename=keyword, post_data=post_data)
        tree.add(
            f":page_facing_up: Post data written/appended to "
            f"[italic][link file://{output_file}]{output_file}[/]"
        )
    post_branch.add(post["data"]["selftext"], style="italic")

    return tree


def get_posts(arguments: argparse):
    """
    Scrapes a given subreddit for posts that contain a specified keyword.
    The search is limited by the number of posts and timeframe specified.

    :param arguments: Namespace object from argparse.

    Expected Object Attributes
    --------------------------
        - keyword: The keyword to search for in the posts.
        - subreddit: The subreddit to scrape.
        - listing: The type of posts to scrape. This could be 'hot', 'new', etc.
        - timeframe: The timeframe from which to scrape posts. This could be 'day', 'week', etc.
        - limit: The maximum number of posts to scrape.
        - json: If specified, all found posts will be written to a json file.
    """
    keyword = arguments.keyword
    subreddit = arguments.subreddit
    listing = arguments.listing
    timeframe = arguments.timeframe
    limit = arguments.limit
    json_output = arguments.json

    # Create main result tree.
    main_tree = Tree(f"[bold]{datetime.now()}[/]", guide_style="bold bright_blue")

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
                f":bust_in_silhouette: #{post_index} by [bold]@{post['data']['author']}[/]"
            )
            found_posts += 1
            create_post_branch(
                post=post,
                keyword=keyword,
                output=json_output,
                tree=found_tree,
            )

    # Log the number of posts in which the keyword was found
    main_tree.add(
        f"Keyword ('{keyword}') was found in {found_posts}/{len(response['data']['children'])} "
        f"{listing} posts from r/{subreddit}."
    )
    xprint(main_tree)


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
        "-j",
        "--json",
        help="Write all found posts to a json file.",
        action="store_true",
    )

    return parser


logging.basicConfig(
    level="NOTSET",
    format="%(message)s",
    handlers=[
        RichHandler(markup=True, log_time_format="[%H:%M:%S%p]", show_level=False)
    ],
)
log = logging.getLogger("rich")
