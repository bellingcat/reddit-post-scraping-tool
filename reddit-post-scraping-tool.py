import logging
import argparse
import requests
#from pprint import pprint
from datetime import datetime

class postScraper:
    def __init__(self, args):
        self.session = requests.session()
        self.session.headers = {'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.1 Safari/605.1.15'}
        
    def Start(self):
        response = self.session.get(f'https://reddit.com/r/{args.subreddit}/{args.listing}.json?limit={args.limit}&t={args.timeframe}').json()
        total_posts = 0
        found_posts = 0
        for post in response['data']['children']:
            total_posts += 1
            if args.keyword.lower() in post['data']['selftext']:
                found_posts += 1
                print(f'\n\n[+] [post: {total_posts}] \'{args.keyword}\' found in body:')
                self.getPosts(post)
            elif args.keyword.lower() in post['data']['title']:
                found_posts += 1
                print(f'\n\n[+] [post: {total_posts}] \'{args.keyword}\' found in title:')
                self.getPosts(post)
            else:
                pass

        logging.info(f"Keyword ('{args.keyword}') was found in {found_posts}/{total_posts} {args.listing} posts from r/{args.subreddit}.")
                

    # Getting posts
    def getPosts(self, post):
        post_data = {'Author': post['data']['author'],
                     'ID': post['data']['id'],
                     'Subreddit': post["data"]["subreddit_name_prefixed"],
                     'Visibility': post['data']['subreddit_type'],
                     #'Author': post["data"]["author_fullname"],
                     'Thumbnail': post["data"]["thumbnail"],
                     'Title': post["data"]["title"],
                     #'Flair': post["data"]["link_flair_text"],
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
                     'Approved by': post['data']['approved_by'],} 
                     
        for key, value in post_data.items():
            print(f"    ├─ {key}: {value}")
        print(f"    └╼ Body: {post['data']['selftext']}\n")
        

# Parsing command line arguments                    
parser = argparse.ArgumentParser(description=f'Written by Richard Mwewa | https://about.me/rly0nheart', epilog=f'Given a subreddit name and a keyword, this script will return all top.(by default) posts that contain the specified word.')
parser.add_argument('-k','--keyword',help='kewyword', required = True)
parser.add_argument('-s','--subreddit',help='subreddit', required = True)
parser.add_argument('-c','--limit',help='results limit (1-100) (default: %(default)s)', default=10, type=int)
parser.add_argument('-l', '--listing', default='top', const='top', nargs='?', choices=['controversial', 'hot', 'best', 'new', 'rising'], help='listings: controversial, hot, best, new, rising (default: %(default)s)')
parser.add_argument('-t','--timeframe', default='all', const='all', nargs='?', choices=['hour', 'day', 'week', 'month', 'year'], help='timeframe: hour, day, week, month, year (default: %(default)s)')
args = parser.parse_args()
start_time = datetime.now()

logging.basicConfig(format=f'[%(asctime)s] %(message)s', datefmt=f'%H:%M:%S%p', level=logging.DEBUG)
if __name__ == '__main__':
    try:
    	postScraper(args).Start()
    	
    except KeyboardInterrupt:
        logging.warning(f'Process interrupted with (Ctrl+C).')
    	
    except Exception as e:
        logging.error(f'An error occured: {e}')
    	
logging.info(f'Finished in {datetime.now()-start_time}s.')
