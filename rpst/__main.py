from datetime import datetime
from rpst.__rpst import log, get_posts, check_updates, create_parser


def run():
    """
    Main entry point for the program. It creates a parser, parses the command line arguments,
    checks for updates, gets posts, and handles any exceptions that occur during the execution.
    """

    # Create a parser and parse the command line arguments
    parser = create_parser()
    arguments = parser.parse_args()

    # Record the start time
    start_time = datetime.now()

    try:
        # Check for updates
        check_updates(version_tag="1.6.1.0")

        # Get posts with the provided/parsed arguments
        get_posts(arguments=arguments)
    except KeyboardInterrupt:
        log.warning("User interruption detected.")
    except Exception as e:
        log.error(f"An error occurred: {e}")
    finally:
        log.info(f'Finished in {datetime.now() - start_time} seconds.')
