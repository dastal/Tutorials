#! /bin/bash

# No arguments
function functionName()
{
	echo "This is a new function"
}

functionName

# One argument
function functionPrint()
{
	echo $1
}

functionPrint Hi

# Multiple Arguments
function functionPrint2()
{
	echo $1 $2 $3 $4 $5
}

functionPrint2 Hi this is an example.

# Local Values
function functionCheck()
{
	returningValue="Using the fucntion right now."
}

returningValue="Hello"
echo $returningValue

functionCheck
echo $returningValue