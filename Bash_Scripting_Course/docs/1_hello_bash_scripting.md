## Hello Bash Scripting ##

- Go to any folder you want
- Enter `touch helloScript.sh`, in this folder there should now appear a file called helloScript.sh
- Open the file to edit it
- Add the following code:

```
#! /bin/bash

echo "hello bash script"
```

- `#! /bin/bash` tells the shell which interpreter it has to use
- `echo "hello bash script"` prints "hello bash script" to the terminal

- The file is only readble at the moment, therefore type `chmod +x helloScript.sh` to make the script executable
- With `ls -al` you can check if the change was done
- Since I am using Ubuntu, to make the file executable, type `sed -i -e 's/\r$//' helloScript.sh` to make it runnable
- Now you can execute the file by using `./helloScript.sh`