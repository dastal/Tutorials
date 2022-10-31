# Introduction to `grep` #
I you want to search for a certain string in a file, you can use grep for it. Have a look at the following code:

```
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
```

First, we search for the file. If the file exists, we can enter a string (`grepVar`). With the command `grep -i $grepVar $fileName` 
we are then going to search for this variable in the respective file.

Flags:
- `-i`: we are going to ignore capital letters
- `-n` we want to have the line number indicated
- `-c` we receive the number of how many times the variable has been used in the file.
- `-v` flag can be used as not command, i.e. we want all the lines that do not contain the respective `grepVar`

For more flags, use the command `man grep` in the terminal.
