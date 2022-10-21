![Screenshot 2022-10-15 231821](https://user-images.githubusercontent.com/74001397/197303749-45032662-810d-4577-b546-13b93d4986d5.png)


Given a subreddit name and a keyword, this script will return all posts from a specified listing (default is 'top') that contain the provided keyword.

# Installation
**1. Clone the repo**
```
git clone https://github.com/rly0nheart/reddit-post-scraping-tool.git
```

**2. Move to reddit-post-scraping-tool directory**
```
cd reddit-post-scraping-tool
```

**3. Install dependencies**
```
pip3 install -r requirements.txt
```

# Usage
```
python3 reddit-post-scraping-tool.py --keyword [keyword] --subreddit [subreddit name (without 'r/')]
```

## Optional arguments
| Option       | Argument    | Choices    | Usage     |
| -------------|:-----------:|-----------:|:---------:|
| -l/--listing | LISTING     | [controversial, hot, best, new, rising]  |  listing: controversial, hot, best, new, rising (default: top)  |
| -c/--limit   | NUMBER      | 1-100      |  results limit (default: 10)|
| -t/--timeframe| TIMEFRAME  | [hour, day, week, month, year]           |  timeframe: hour, day, week, month, year (default: all) |
