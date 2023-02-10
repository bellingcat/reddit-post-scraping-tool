from reddit_post_scraping_tool.reddit_post_scraping_tool import *


def main():
    try:
        reddit_post_scraper()
    except KeyboardInterrupt:
        log.warning(f"User interruption detected.")
    except Exception as e:
        log.error(e)
    finally:
        log.info(f'Finished in {datetime.now() - start_time} seconds.')
