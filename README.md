# Reddit Post Scraping Tool
Given a subreddit name and a keyword, this script will return all posts from a specified listing (default is 'top') that contain the provided keyword.

![Screenshot 2023-02-10 195818](https://user-images.githubusercontent.com/74001397/218163494-245f6676-1fb3-4680-a6b5-bd15fb1dea5e.png)
![Screenshot_20230210_193329](https://user-images.githubusercontent.com/74001397/218158084-9295abb7-df33-4f86-8df8-e109cac7cde6.png)



# Installation
### Note
> The program has both a CLI and a GUI
## Installing the CLI
#### Note
> The cli is cross-platform and in order to use it, you will need to have Python installed on your system
### Install rom [PyPI](https://pypi.org/project/reddit-post-scraping-tool)
```
pip install reddit-post-scraping-tool
```

### Install the dev version from [GitHub](https://github.com/rly0nheart/reddit-post-scraping-tool)
#### Note
> The dev version might be unstable
```
pip install git+https://github.com/rly0nheart/reddit-post-scraping-tool
```

### Usage

```
reddit_post_scraping_tool --keyword [keyword] --subreddit [subreddit name (without 'r/')]
```

### Optional arguments
| Option       | Argument    | Choices    | Usage     |
| -------------|:-----------:|-----------:|:---------:|
| -l/--listing | LISTING     | [controversial, hot, best, new, rising]  |  listing: controversial, hot, best, new, rising (default: top)  |
| -c/--limit   | NUMBER      | 1-100      |  results limit (default: 10)|
| -t/--timeframe| TIMEFRAME  | [hour, day, week, month, year]           |  timeframe: hour, day, week, month, year (default: all) |

## Setting up the GUI
#### Note
> The GUI is only available for Windows systems

### Prerequisites
* **.NET 6.0 or later**

### 1. Download the GUI from the releases page

You can download the latest release of the gui from [here](https://github.com/bellingcat/octosuite/releases/latest)


### 2. Extract the downloaded `.zip`
![Screenshot_20230210_181651](https://user-images.githubusercontent.com/74001397/218141653-991a91cd-93d5-4640-b2f2-37d29e6a9c62.png)

### 3. Run the binary

Once extracted, you can then run the program by double clicking on a binary named `RPST.exe`
![Screenshot_20230210_181933](https://user-images.githubusercontent.com/74001397/218142422-70f19a0a-db39-42ee-8ad4-22fe380e249b.png)

![Screenshot_20230210_182210](https://user-images.githubusercontent.com/74001397/218142782-0a9ca4fb-7609-4855-a96b-c58885161166.png)
