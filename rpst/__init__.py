import os

__author__: str = "Richard Mwewa"
__about_author__: str = "https://about/me/rly0nheart"
__version__: str = "2.0.0.0"

__description__: str = f"""
# RPST (Reddit Post Scraping Tool) {__version__}
> Retrieve Reddit posts that contain the specified keyword from a specified subreddit.
"""
__epilog__: str = f"""
# by [{__author__}]({__about_author__})

```
MIT License

Copyright (c) 2023 {__author__}

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
"""

# Construct path to the program's directory
PROGRAM_DIRECTORY: str = os.path.expanduser(
    os.path.join("~", "reddit_post_scraping_tool")
)
