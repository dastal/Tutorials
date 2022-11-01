# Introduction to `sed` #
`sed` can be used to manipulate text files and substituting purposes.

Have a look at the following code snippet:

```
echo "Enter the filename to substitute using sed:"
read fileName

if [[ -f $fileName ]]
then
	cat examplefile.txt | sed 's/i/I/'
else
	echo "$fileName does not exist."
fi
```

In the command sequence `cat examplefile.txt | sed 's/i/I'` we first navigate to the file, then we want to substitute the first "i"s in each line with "I"s.
When we want to substitute all the "i"s in the file, we need to use the line `sed 's/i/I/g' $fileName`.
But: this changes are not made in the file yet. To do so, we simply save the new content in a new file, by using the command
`sed 's/i/I/g' $fileName > newFile.txt`. I f you want to do the changes in the same file you read the data,
use the command `sed -i 's/i/I/g' $fileName`, but mind that the changes will be done permanently! If you want to substitute whole wordsl, this is also possible$
by using the command `sed 's/oldWord/newWord/g' $fileName`.
