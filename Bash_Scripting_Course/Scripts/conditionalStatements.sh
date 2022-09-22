#! /bin/bash

count=10

# Using equal

if [ $count -eq 10 ]
then
	echo "The condition is true."
fi

# Using not equal

if [ $count -ne 9 ]
then
	echo "The condition is true."
fi

# Using greater than

if [ $count -gt 9 ]
then
	echo "The condition is true."
fi

# or

if (( $count > 9 ))
then
	echo "The condition is true."
fi

# Using smaller than

if [ $count -lt 11 ]
then
	echo "The condition is true."
fi

# or

if (( $count < 11 ))
then
	echo "The condition is true."
fi

# With "else"

if [ $count -eq 9 ]
then
	echo "The condition is true."
else
	echo "The condition is false."
fi

# if - else if

if [ $count -eq 9 ]
then
	echo "The first condition is true."
elif (( $count <= 10 ))
then
	echo "The second condition is true."
else
	echo "The condition is false."
fi

# And Operator

age=10

if [ "$age" -gt 18 ] && [ "$age" -lt 40 ]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi

# Same way

if [[ "$age" -gt 18 && "$age" -lt 40 ]]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi

# or

if [ "$age" -gt 18 -a "$age" -lt 40 ]
then
	echo "The age is between 18 and 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi

# Or operator

if [[ "$age" -gt 18 || "$age" -lt 40 ]]
then
	echo "The age is either greater than 18 or smaller than 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi

# Same way

if [ "$age" -gt 18 -o "$age" -lt 40 ]
then
	echo "The age is either greater than 18 or smaller than 40."
else
	echo "The age is either smaller than 18 or greater than 40."
fi

# Case Statement

answer="yes"

case $answer in
	yes | Yes)
		echo "The answer is yes."
		;;
	no | No)
		echo "The answer is no."
		;;
	*)
		echo "No answer given."
		;;
esac