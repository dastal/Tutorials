#! /bin/bash

# Input from the Command Line

# echo $1 $2 $3

# args=("$@")

# echo ${args[0]} ${args[1]} ${args[2]}

# echo $@

# echo $#

# Input from a File

while read line
do
	echo "$line"
done < "${1:-/dev/stdin}"