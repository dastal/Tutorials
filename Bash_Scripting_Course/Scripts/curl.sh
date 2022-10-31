#! /bin/bash

url="https://proof.ovh.net/files/1Mb.dat"
# curl ${url} -O
# curl ${url} -o NewFileDw
# curl ${url} > OutputFile
curl -I ${url}