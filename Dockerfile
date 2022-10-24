FROM python:latest

ADD requirements.txt /

ADD reddit-post-scraping-tool.py /

COPY ./reddit-post-scraping-tool.py ./

RUN pip install -r requirements.txt

ENTRYPOINT ["python", "./reddit-post-scraping-tool.py"]
