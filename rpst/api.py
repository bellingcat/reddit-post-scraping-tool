# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #

from typing import Union

import aiohttp

from .coreutils import log

# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #


REDDIT_ENDPOINT: str = "https://www.reddit.com"
PYPI_PROJECT_ENDPOINT: str = "https://pypi.org/pypi/reddit-post-scraping-tool/json"


# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #


async def get_data(session: aiohttp.ClientSession, endpoint: str) -> Union[dict, list]:
    """
    Fetches JSON data from a given API endpoint.

    :param session: aiohttp session to use for the request.
    :param endpoint: The API endpoint to fetch data from.
    :return: Returns JSON data as a dictionary or list. Returns an empty dict if fetching fails.
    """

    try:
        async with session.get(
            endpoint,
        ) as response:
            if response.status == 200:
                return await response.json()
            else:
                error_message = await response.json()
                log.error(f"An API error occurred: {error_message}")
                return {}

    except aiohttp.ClientConnectionError as error:
        log.error(f"An HTTP error occurred: {error}")
        return {}
    except Exception as error:
        log.critical(f"An unknown error occurred: {error}")
        return {}


# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #


async def get_updates(session: aiohttp.ClientSession):
    """
    Gets and compares the current program version with the remote version.

    Assumes version format: major.minor.patch.prefix

    :param session: aiohttp session to use for the request.
    """
    from . import __version__

    # Make a GET request to PyPI to get the project's latest release.
    response: dict = await get_data(endpoint=PYPI_PROJECT_ENDPOINT, session=session)

    if response.get("info"):
        release: dict = response.get("info")
        remote_version: str = release.get("version")
        # Splitting the version strings into components
        remote_parts: list = remote_version.split(".")
        local_parts: list = __version__.split(".")

        update_message: str = ""

        # Check for differences in version parts
        if remote_parts[0] != local_parts[0]:
            update_message = (
                f"MAJOR update ({remote_version}) available."
                f" It might introduce significant changes."
            )

        elif remote_parts[1] != local_parts[1]:
            update_message = (
                f"MINOR update ({remote_version}) available."
                f" Includes small feature changes/improvements."
            )

        elif remote_parts[2] != local_parts[2]:
            update_message = (
                f"PATCH update ({remote_version}) available."
                f" Generally for bug fixes and small tweaks."
            )

        elif (
            len(remote_parts) > 3
            and len(local_parts) > 3
            and remote_parts[3] != local_parts[3]
        ):
            update_message = (
                f"BUILD update ({remote_version}) available."
                f" Might be for specific builds or special versions."
            )

        if update_message:
            log.info(update_message)


# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #
async def get_posts(
    subreddit: str,
    listing: str,
    timeframe: str,
    limit: int,
    session: aiohttp.ClientSession,
) -> list:
    all_posts = await paginated_posts(
        posts_endpoint=f"{REDDIT_ENDPOINT}/r/{subreddit}/{listing}.json?limit={limit}&t={timeframe}",
        limit=limit,
        session=session,
    )

    return all_posts[:limit]


# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #


async def paginated_posts(
    posts_endpoint: str, limit: int, session: aiohttp.ClientSession
) -> list:
    """
    Paginates and retrieves posts until the specified limit is reached.

    :param posts_endpoint: API endpoint for retrieving posts.
    :param limit: Limit of the number of posts to retrieve.
    :param session: aiohttp session to use for the request.
    :return: A list of all posts.
    """
    all_posts: list = []
    last_post_id: str = ""

    # Determine whether to use the 'after' parameter
    use_after: bool = limit > 100

    while len(all_posts) < limit:
        # Make the API request with the 'after' parameter if it's provided and the limit is more than 100
        if use_after and last_post_id:
            endpoint_with_after: str = f"{posts_endpoint}&after={last_post_id}"
        else:
            endpoint_with_after: str = posts_endpoint

        posts_data: dict = await get_data(endpoint=endpoint_with_after, session=session)
        posts_children: list = posts_data.get("data", {}).get("children", [])

        # If there are no more posts, break out of the loop
        if not posts_children:
            break

        all_posts.extend(posts_children)

        # We use the id of the last post in the list to paginate to the next posts
        last_post_id: str = all_posts[-1].get("data").get("id")

    return all_posts


# +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ #
