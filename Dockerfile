# syntax=docker/dockerfile:1

FROM python:latest

WORKDIR /app

COPY . .

RUN pip install --upgrade pip && pip install .

ENTRYPOINT ["rpst"]
