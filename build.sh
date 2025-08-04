#!/bin/bash

source .env
echo "Using conn string starting ${MDBCONNSTR:0:18}..."

datehash=`date | md5sum | cut -d" " -f1`
abbrvhash=${datehash: -8}

echo
echo "+======================"
echo "| START: MonopoSaver"
echo "+======================"
echo

echo 
echo "Building container using tag ${abbrvhash}"
echo
docker build -t graboskyc/monoposaver:${abbrvhash} .

EXITCODE=$?

echo
echo "MonopoSaver: Starting container"
echo

if [ $EXITCODE -eq 0 ]
    then

    docker stop monoposaver
    docker rm monoposaver
    docker run -t -i -d -p 9999:8080 --name monoposaver -e "MDBCONNSTR=${MDBCONNSTR}" --restart unless-stopped graboskyc/monoposaver:${abbrvhash}

    echo
    echo "+================================"
    echo "| END: MonopoSaver"
    echo "+================================"
    echo

else
    echo
    echo "+================================"
    echo "| ERROR: Build failed"
    echo "+================================"
    echo
fi