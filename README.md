Given a subreddit name and a keyword, this script will return all top (by default) posts that contain the specified word.

## Installation
```
git clone https://github.com/rly0nheart/reddit-post-scraping-tool.git
```

```
cd reddit-post-scraping-tool
```

## Usage
```
python reddithposthscrapinghtool.py --keyword [keyword] --subreddit [subreddit]
```

## Optional arguments
| Option       | Argument    | Choices    | Usage     |
| -------------|:-----------:|-----------:|:---------:|
| -l/--listing | LISTING     | [controversial, hot, best, new, rising]  |  listing: controversial, hot, best, new, rising (default: top)  |
| -c/--limit   | NUMBER      | 1-100      |  results limit (default: 10)|
| -t/--timeframe| TIMEFRAME  | [hour, day, week, month, year]           |  timeframe: hour, day, week, month, year (default: all) |

Happy hunting!✌🏾😎
