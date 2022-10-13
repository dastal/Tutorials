# Script Input & Output #

## Script Input ##
Following a list of different ways to read input.

### Input from the Command Line ###
The following code takes three different variables as input:

```
echo $1 $2 $3
```

For running the code on the command line, we can use for example:

```
./script_in_out.sh BMW MERCEDES OPEL
```

So $1 takes the input "BMW", $2 takes the input "MERCEDES" and $3 takes the input "OPEL". As soon as we hit enter, on the next line the three input variables appear again since we let them print out in our script.

If we pass additionally a `$0` to the echo statement, the name of the script would be printed out as well.

If we do not know how many arguments we are going to give as an input, we can define a array that saves all the incomming variables. I looks as follows:

```
args=("$@")
```

Whereas the `$@` indicates that we are going to input a mutable number of variables. If we want to print out all the vlaues inside this array, we can use the following command:

```
echo $@
```

Additionally, if we want to know the length of the array containing the input, we can use:

```
echo $#
```

### Input from a File ###
Now we want to hand in a file as an input. Therefore consider the following code:

```
while read line
do
	echo "$line"
done < "${1:-/dev/stdin}"
```

It takes every single line of the file as an input and prints it to the command line. By executig the file with the normal command `./fileName.sh`, on the command line there appears an input line, where the user can directly hand in the input line by line by hitting enter after each line. To finish the input, the user must enter "ctrl + c".

If we want to hand in a file, we have to enter the following command:

```
./fileName.sh inputFile.txt
```

This command takes the file, the bash script reads it line by line and after every line, the line is printed to the console.


## Script Output ##

