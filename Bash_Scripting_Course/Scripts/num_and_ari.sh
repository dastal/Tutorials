#! /bin/bash

# Integer Numbers
n1=28
n2=4

echo $(( n1 + n2 ))
echo $(( n1 - n2 ))
echo $(( n1 * n2 ))
echo $(( n1 / n2 ))
echo $(( n1 % n2 ))

echo $(expr $n1 + $n2 )
echo $(expr $n1 - $n2 )
echo $(expr $n1 \* $n2 )
echo $(expr $n1 / $n2 )
echo $(expr $n1 % $n2 )

# Hexadecimal numbers
echo "Enter the hexadecimal number of your choice: "
read hex

echo -n "The decimal value of $hex is: "

echo "obase=10; ibase=16; $hex" | bc