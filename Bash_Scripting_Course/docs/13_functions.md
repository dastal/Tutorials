# Functions #

## Function with no Arguments ##
The template for a function in bash is:

```
function functionName()
{
	do something
}
```

To call the function, simply use:

```
functionName
```

## Function with one or multiple Arguments ##
A function with one or multiple arguments works for example as follwos:

```
function functionPrint()
{
	echo $1 $2 $3 $4 $5
}
```

To call it then, use for example

functionPrint Hi this is an example.

## Local Variables in Functions ##
Local Variables in Functions are only used in functions, like the following template:

```
function functionName()
{
	returningValue="Some value"
	echo "$returningValue"
}
```

But: once the function is called, the internal and local variable that was declared in the function can also be used outside the function:

```
functionCheck
echo $returningValue
```