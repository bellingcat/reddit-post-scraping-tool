from datetime import datetime
from rpst.__rpst import log, start_scraper, check_updates, create_parser


def run():
    """
    Main entry point for the program. It creates a parser, parses the command line arguments,
    checks for updates, starts the scraper, and handles any exceptions that occur during the execution.
    """

    # Create a parser and parse the command line arguments
    parser = create_parser()
    args = parser.parse_args()

    # Record the start time
    start_time = datetime.now()

    try:
        # Check for updates
        check_updates(version_tag="1.4.0.0")

        # Start the scraper with the parsed arguments
        start_scraper(keyword=args.keyword, subreddit=args.subreddit,
                      listing=args.listing, timeframe=args.timeframe, limit=args.limit)
    except KeyboardInterrupt:
        log.warning("User interruption detected.")
    except Exception as e:
        log.error(f"An error occurred: {e}")
    finally:
        log.info(f'Finished in {datetime.now() - start_time} seconds.')
