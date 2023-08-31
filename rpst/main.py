from datetime import datetime

from .rpst import get_posts
from .utils import create_parser, set_loglevel, check_updates


def run():
    """
    Main entry point for the program. It creates a parser, parses the command line arguments,
    checks for updates, gets posts, and handles any exceptions that occur during the execution.
    """

    # Create a parser and parse the command line arguments
    parser = create_parser()
    args = parser.parse_args()

    log = set_loglevel(debug_mode=args.debug)

    # Record the start time
    start_time = datetime.now()

    try:
        # Check for updates
        check_updates(version_tag="1.9.1.0")

        # Get posts with the provided/parsed arguments
        get_posts(args=args)
    except KeyboardInterrupt:
        log.warning("User interruption detected ([yellow]Ctrl+C[/]).")
    except Exception as e:
        log.error(f"An error occurred: [red]{e}[/]")
    finally:
        log.info(f"Finished in {datetime.now() - start_time} seconds.")
