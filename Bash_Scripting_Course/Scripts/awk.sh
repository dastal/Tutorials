#! /bin/bash

echo "Enter the filename that you want to print using awk:"
read fileName

if [[ -f $fileName ]]
then
	# awk '{print}' $fileName
	# awk '/Linux/ {print}' $fileName
	# awk '/Windows/ {print $2}' $fileName
	awk '/Mac/ {print $3,$4}' $fileName
else
	echo "$fileName does not exist."
fi