#! /bin/bash

echo "Enter the file name to search it."
read fileName

if [ -f $fileName ]
then
	echo "Enter the text to search:"
	read grepVar
	grep -i $grepVar $fileName
	grep -i -n $grepVar $fileName
	grep -i -n -c $grepVar $fileName
	grep -i -v $grepVar $fileName
else
	echo "The file does not exist."
fi