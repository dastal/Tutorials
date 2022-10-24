# Script Output #
The command `ls -al` lists the whole content of the current directory.

If we now want to save the content of the directory in a file, we use the following command:

```
ls -al 1>file1.txt 2>file2.txt
```

whereas the content will be saved in the first file, and the second file will be empty.

But if we intentionally write an error into the command, like the following:

```
ls +al 1>file1.txt 2>file2.txt
```

In this case, the first file with the output will stay empty and the second file will then contain the error message of the error.

So generally, if we create two output files, then the first file is meant for the standard output which will appear on the terminal if no file ist specified.
The second file is meant for the standard error which will normally appear on the terminal if no file is specified for it.
If one file is not specified, then the standard output or standard error (depending on which file is not specified) will appear as usual on the terminal.

It is also possible to specify one file for both, standard output and standard error. Therefore we use the following command:

```
ls +al >std_out.txt 2>&1
```

Important to know here is that every time the script is executed, it gets overwritten.

There is also a shortcut for this command:

```
ls -al >& std_out.txt
```

