#! /bin/bash

echo "Enter the filename to substitute using sed:"
read fileName

if [[ -f $fileName ]]
then
	# cat files/sedfile.txt | sed 's/i/I/'
	# sed 's/i/I/g' $fileName
	# sed -i 's/i/I/g' $fileName
	# sed 's/i/I/g' $fileName > files/newSedfile.txt
	sed 's/Linux/Unix/g' $fileName
else
	echo "$fileName does not exist."
fi