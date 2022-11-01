# Introduction to `awk` #
`awk` is a scripting language that is used for manipulating data. It has its own file-type, called ".fh". 
However, it can also be used in bash scripting.

Main actions that can be made using `awk`:
- Scanning a file
- Search for specific string snippets
- Printing fields of specific lines

## Scanning a File ##
Look at the following code:

```
echo "Enter the filename that you want to print using awk:"
read fileName

if [[ -f $fileName ]]
then
	awk '{print}' $fileName
else
	echo "$fileName does not exist."
fi
```

With the command `awk '{print}' $fileName` we just print the content of the whole file to the terminal.

## Searching for specific String Snippets##
Look at the following code snippet:

```
echo "Enter the filename that you want to print using awk:"
read fileName

if [[ -f $fileName ]]
then
	awk '/Term/ {print}' $fileName
else
	echo "$fileName does not exist."
fi
```

With the sequence `/Term/` we are able to search for exactly the word term in the whole file. When this term is contained in the file, the respective line will be printed to the terminal.

## Printing Fields of specific lines ##
Have a look at the following code:

```
echo "Enter the filename that you want to print using awk:"
read fileName

if [[ -f $fileName ]]
then
	awk '/Term/ {print $2}' $fileName
else
	echo "$fileName does not exist."
fi
```

The part with `{print $2}` will print the second field (in this case word) of the respective line.
This is also possible for multiple fields, therefore just use for example `awk '/Term/ {print $2,$3}' $fileName`, which will in this case the second and the third field.
