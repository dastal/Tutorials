#! /bin/bash

# Select Method
: 'select car in OPEL TOYOTA TESLA PEUGEOT FORD
do
	case $car in
	OPEL)
		echo "You have selected OPEL.";;
	TOYOTA)
		echo "You have selected TOYOTA.";;
	TESLA)
		echo "You have selected TESLA.";;
	PEUGEOT)
		echo "You have selected PEUGEOT.";;
	FORD)
		echo "You have selected FORD.";;
	*)
		echo "ERROR: Please select between 1..5.";;
	esac		
done'

# While Loop Mehtod
echo "Press any key to continue."

while [ true ]
do
	read -t 3 -n 1
if [ $? = 0 ]
then
	echo "You terminated the script."
	exit;
else
	echo "Waiting for you to press the key."
fi

done