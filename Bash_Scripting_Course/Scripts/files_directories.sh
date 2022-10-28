#! /bin/bash

# Directories
mkdir -p Directory2

echo "Enter directory name to check:"
read direct

if [ -d "$direct" ]
then
	echo "$direct exists."
else
	echo "$direct does not exist."
fi

# Files
echo "Enter file name name to create:"
read fileName

touch $fileName

echo "Enter file name name to check:"
read fileNameCheck

if [ -f "$fileNameCheck" ]
then
	echo "$fileNameCheck exists."
	echo "Enter the text you want to append to the file:"
	read fileText
	echo "$fileText" >> $fileNameCheck
else
	echo "$fileNameCheck does not exist."
fi

# Reading file line by line
echo "Enter file name name from which you want to read:"
read fileNameRead

if [ -f "$fileNameRead" ]
then
	while IFS= read -r line
	do
		echo "$line"
	done < $fileNameRead
else
	echo "$fileNameCheck does not exist."
fi

# Deleting the file
echo "Enter file name name which you want to delete:"
read fileNameDelete

if [ -f "$fileNameDelete" ]
then
	rm $fileNameDelete
	echo "The file has been deleted successfully."
else
	echo "$fileNameDelete does not exist."
fi