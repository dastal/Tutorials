#! /bin/bash

# Comparison
echo "Enter First String: "
read st1

echo "Enter Second String: "
read st2

if [ "$st1" == "$st2" ]
then
	echo "Both strings match."
else
	echo "The strings do not match."
fi

if [ "$st1" \> "$st2" ];
then
	echo "Case 1: $st1 is smaller than $st2."
elif [ "$st1" \< "$st2" ];
then
	echo "Case 2: $st2 is smaller than $st1."
else
	echo "Both strings are equal."
fi

# Concatenation
c=$st1$st2

echo $c

# Lowercase
echo ${st1,,}

# Uppercase
echo ${st1^^}

# First Letter is a Capital Letter
echo ${st2^}

# Capitalize a specific letter
echo ${st2^^r}