# Professional Menus #
There are two different ways to create a menu in bash. The first one is by using the `select` method, as follows:

```
: 'select something in menu_array
do
	case $something in
	SOMETHING1)
		echo "You have selected SOMETHING1.";;
	SOMETHING2)
		echo "You have selected SOMETHING2.";;
	SOMETHING3)
		echo "You have selected SOMETHING3.";;
	SOMETHING4)
		echo "You have selected SOMETHING4.";;
	SOMETHING5)
		echo "You have selected SOMETHING5.";;
	*)
		echo "ERROR: Please select between 1..5.";;
	esac		
done
```

Here, you give 5 different objects as choice for the user (could also be more). With the `case` statement we limit the choice, such that the user can only select between 1..5.

Another way to create a menu is using a while loop, as follows:

```
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
```

Here we can make an additional read command that reads the user input. The while loop basically waits until the user has done an input, otherwise it reminds the user every 3 seconds to enter an input (with `-t 3` in the read command).