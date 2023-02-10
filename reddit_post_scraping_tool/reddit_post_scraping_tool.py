import logging
import argparse
import requests
from rich.tree import Tree
from datetime import datetime
from rich import print as xprint
from rich.logging import RichHandler

start_time = datetime.now()
logging.basicConfig(level="NOTSET", format="%(message)s", handlers=[RichHandler(markup=True, log_time_format='[%H:%M:%S%p]')])
log = logging.getLogger("rich")


# Getting posts
def get_posts(post):
    post_data = {'Author': post['data']['author'],
                 'ID': post['data']['id'],
                 'Subreddit': post["data"]["subreddit_name_prefixed"],
                 'Visibility': post['data']['subreddit_type'],
                 # 'Author': post["data"]["author_fullname"],
                 'Thumbnail': post["data"]["thumbnail"],
                 # 'Flair': post["data"]["link_flair_text"],
                 'NSFW': post['data']['over_18'],
                 'Gilded': post['data']['gilded'],
                 'Upvotes': post["data"]["ups"],
                 'Upvote ratio': post["data"]["upvote_ratio"],
                 'Downvotes': post["data"]["downs"],
                 'Awards': post["data"]["total_awards_received"],
                 'Top award': post['data']['top_awarded_type'],
                 'Is crosspostable?': post['data']['is_crosspostable'],
                 'Score': post["data"]["score"],
                 'Category': post['data']['category'],
                 'Domain': post["data"]["domain"],
                 'Created': post['data']['created'],
                 'Approved at': post['data']['approved_at_utc'],
                 'Approved by': post['data']['approved_by'], }

    post_tree = Tree("\n" + post['data']['title'])
    for post_key, post_value in post_data.items():
        post_tree.add(f"{post_key}: {post_value}")
    xprint(post_tree)
    print(post['data']['selftext'] + "\n")


def reddit_post_scraper():
    session = requests.session()
    session.headers = {'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.1 Safari/605.1.15'}
    response = session.get(f'https://reddit.com/r/{args.subreddit}/{args.listing}.json?limit={args.limit}&t={args.timeframe}').json()
    found_posts = 0
    for post in response['data']['children']:
        if args.keyword.lower() in post['data']['selftext'] or args.keyword.lower() in post['data']['title']:
            found_posts += 1
            get_posts(post)

    log.info(f"Keyword ('{args.keyword}') was found in {found_posts}/{len(response['data']['children'])} {args.listing} posts from r/{args.subreddit}.")


def create_parser():
    parser = argparse.ArgumentParser(
        description=f'reddit-post-scraping-tool — by Richard Mwewa | https://about.me/rly0nheart',
        epilog=f'Given a subreddit name and a keyword, this program returns all top (by default) posts that contain the specified word. ')
    parser.add_argument('-k', '--keyword', help='kewyword', required=True)
    parser.add_argument('-s', '--subreddit', help='subreddit', required=True)
    parser.add_argument('-c', '--limit', help='results limit (1-100) (default: %(default)s)', default=10, type=int)
    parser.add_argument('-l', '--listing', default='top', const='top', nargs='?',
                        choices=['controversial', 'hot', 'best', 'new', 'rising'],
                        help='listings: controversial, hot, best, new, rising (default: %(default)s)')
    parser.add_argument('-t', '--timeframe', default='all', const='all', nargs='?',
                        choices=['hour', 'day', 'week', 'month', 'year'],
                        help='timeframe: hour, day, week, month, year (default: %(default)s)')
    return parser


_parser = create_parser()
args = _parser.parse_args()
