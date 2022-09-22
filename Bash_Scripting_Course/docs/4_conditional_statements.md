# Conditional Statements #

General: Make sure that between a variable and the equal-sign and between the equal sign and the value there is no whitspace!

## If Statement ##
Make sure that you always have a whitespace between if and the square bracket ([). The statement in the square bracket also needs a white space on each side.

The skeleton of the if statement is (using `-` operators, e.g. `-eq`)

```
if [ statment1 ]
then
	echo "The first condition is true."
elif [ statment2 ]
then
	echo "The second condition is true."
else
	echo "The condition is false."
fi
```

The skeleton of the if statement is (using mathematical operators, e.g. `<`)

```
if (( statment1 ))
then
	echo "The first condition is true."
elif (( statment2 ))
then
	echo "The second condition is true."
else
	echo "The condition is false."
fi
```

The example of an if statement using a combined statement (e.g. by using th and operator) is:

```
if [ "$age" -gt 18 ] && [ "$age" -lt 40 ]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi
```

It can also be written as:

```
if [[ "$age" -gt 18 && "$age" -lt 40 ]]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi
```

or also as:

```
if [ "$age" -gt 18 -a "$age" -lt 40 ]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi
```


## Mathematical Operators ##
Following a list of operators:
- Equals: `-eq` (for numbers), `==` for strings
- Not equals: `-ne` (for numbers), `!=` for strings
- Greater than: `-gt`, `<`
- Greater or equal than: `-ge`, `<=`
- Smaller than: `-lt`, `>`
- Smaller or equal than: `-le`, `>=`

## Logical Operators ##
- And: `&&` or `-a`
- Or: `||` or `-o`

# Case Statement
The skeleton of the case statement is as follows:

```
case $variable in
	statement1)
		echo "Statement1 is true."
		;;
	statement2)
		echo "Statement2 is true."
		;;
	*)
		echo "None of the statements are true."
		;;
esac
```