import setuptools

with open("README.md", "r", encoding="utf-8") as file:
    long_description = file.read()

setuptools.setup(
    name="reddit-post-scraping-tool",
    version="1.1.0.0",
    author="Richard Mwewa",
    author_email="rly0nheart@duck.com",
    packages=["reddit_post_scraping_tool"],
    description="Given a subreddit name and a keyword, this program returns all top (by default) posts that contain the specified word.",
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="https://github.com/rly0nheart/reddit-post-scraping-tool",
    license="MIT License",
    install_requires=["rich", "requests"],
    classifiers=[
        'Development Status :: 5 - Production/Stable',
        'Intended Audience :: Information Technology',
        'License :: OSI Approved :: MIT License',
        'Operating System :: OS Independent',
        'Natural Language :: English',
        'Programming Language :: Python :: 3'
        ],
    entry_points={
        "console_scripts": [
            "reddit_post_scraping_tool=reddit_post_scraping_tool.main:main",
        ]
    },
)
