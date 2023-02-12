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

# Windows GUI
## Prerequisites
* **.NET 6.0 or later**

### 1. Download the GUI from the releases page

You can download the latest release of the gui from [here](https://github.com/bellingcat/octosuite/releases/latest)


### 2. Extract the downloaded `.zip`
![Screenshot_20230210_181651](https://user-images.githubusercontent.com/74001397/218141653-991a91cd-93d5-4640-b2f2-37d29e6a9c62.png)

### 3. Run the binary

Once extracted, you can then run the program by double clicking on a binary named `RPST.exe`
![Screenshot_20230210_181933](https://user-images.githubusercontent.com/74001397/218142422-70f19a0a-db39-42ee-8ad4-22fe380e249b.png)

![Screenshot_20230210_182210](https://user-images.githubusercontent.com/74001397/218142782-0a9ca4fb-7609-4855-a96b-c58885161166.png)
