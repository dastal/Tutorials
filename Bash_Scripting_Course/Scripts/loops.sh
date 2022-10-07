#! /bin/bash

# While Loop

number=1

while [ $number -le 10 ]
do
	echo "$number"
	number=$(( number+1 ))
done

# Until Loop

number=1

until [ $number -gt 10 ]
do	
	echo "$number"
	number=$(( number+1 ))
done

# For Loop (small loops)
for i in 1 2 3 4 5
do
	echo $i
done


# bigger loops
for i in {0..20}
do
	echo $i
done

for i in {0..20..2}
do
	echo $i
done

for (( i=0; i<=5; i++ ))
do
	echo $i
done

## break and continue
for (( i=0; i<=10; i++ ))
do
	if [ $i -gt 5 ]
	then
		break
	fi
	echo $i
done

for (( i=0; i<=10; i++ ))
do
	if [ $i -eq 3 ] || [ $i -eq 7 ]
	then
		continue
	fi
	echo $i
done

