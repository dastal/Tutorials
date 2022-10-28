# Files and Directories #

## Directories ##
Creating a directory:

```
mkdir -p Directory_Name
```

The `-p` in this command is to avoid that the directory is recreated again once it was created.

It is possible to check if a directory exists. Have a look at the following code

```
echo "Enter directory name to check:"
read direct

if [ -d "$direct" ]
then
	echo "$direct exists."
else
	echo "$direct does not exist."
fi
```

In the if statement, the `-d` enables to check the names of the directories in the current directory.

## Files ##
Creating a file:

```
touch fileName
```

It is possible to check if a file exists. Have a look at the following code

```
echo "Enter file name name to check:"
read fileName

if [ -f "$fileName" ]
then
	echo "$fileName exists."
else
	echo "$fileName does not exist."
fi
```

In the if statement, the `-f` enables to check the names of the files in the current directory.

## Appending text into a file ##
To append text into an exisiting file, use:

```
echo "$someText" >> $fileNameCheck
```

This way we can append text snippets one after another. In case you always want to overwrite the existing text use:

```
echo "$someText" > $fileNameCheck
```

In case you want to read the whole text in the file line by line, use:

```
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
```

In case you want to delete the file, use:

```
echo "Enter file name name which you want to delete:"
read fileNameDelete

if [ -f "$fileNameDelete" ]
then
	rm $fileNameDelete
else
	echo "$fileNameDelete does not exist."
fi
```