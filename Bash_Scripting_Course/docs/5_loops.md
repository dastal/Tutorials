# Loops #

## While Loop ##

The skeleton of the while loop looks as follows:

```
while [ condition ]
do
	do something
	increment/ decrement
done
```

## Until Loop ##
In contrast to the while loop which executes the loop until condition is false, the until loop executes the loop until the condition is true.
The skeleton of the until loop looks as follwos:

```
until [ condition ]
do	
	do something
	increment/ decrement
done
```

## For Loops ##
The skeleton of the for loop looks as follows:

```
for i in {range}
do
	do something
done
```

The range can be defined in many different ways, some of them are listed in the following list
- `for i in 1 2 3 4 5` for small ranged loops
- `for i in {0..20}` for bigger ranged loops
- `for i in {0..20..2}` for bigger ranged loops with stepsize unequal to 1
- `for (( i=0; i<=5; i++ ))` another way to write a for loop

## `break` and `continue` Statements ##
With the break statement we can interrupt a loop although the condidion is still true. With the continue statement we are able to skip a certain point in the range.

