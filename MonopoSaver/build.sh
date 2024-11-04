#!/bin/bash

echo
echo "+================================"
echo "| START: monoposaver"
echo "+================================"
echo

datehash=`date | md5sum | cut -d" " -f1`
abbrvhash=${datehash: -8}

echo 
echo "Building container using tag ${abbrvhash}"
echo
docker build -t graboskyc/monoposaver:latest -t graboskyc/monoposaver:${abbrvhash} .

EXITCODE=$?

if [ $EXITCODE -eq 0 ]
    then

    echo 
    echo "Starting container"
    echo
    docker stop monoposaver
    docker rm monoposaver
    docker run -t -i -d -p 8000:8000 --name monoposaver --restart unless-stopped graboskyc/monoposaver:${abbrvhash}

    echo
    echo "+================================"
    echo "| END:  monoposaver"
    echo "+================================"
    echo
else
    echo
    echo "+================================"
    echo "| ERROR: Build failed"
    echo "+================================"
    echo
fi