# Pipes #

Using pipes to send output from one script to another. Therefore we first need two files, one that exports something and the other one that does something with the export from the first file.

## Expoirting File ##
Look at the following code:

```
MESSAGE="Some example text that is the export object"
export MESSAGE
./path/to/receving_file.sh
```

In this code, a message is defined and made exported with the `export` statement in the second line. In the third line the receiving file is executed.

## Receiving File ##
Look ath the following code:

```
echo "The message from the original script is: $MESSAGE"
```

This script basically just prints out the message from the exporting file, by using `$MESSAGE` that was defined in the exporting file.

## Important ##
Important here is that both files are executable and not just readable. Therefore, make the second file executable with the command:

```
chmod +x receiving_file.sh
```

Also, make sure that both files are converted to the UNIX line style when using Windows. Herefore use the command:

```
sed -i -e 's/\r$//' file_name.sh
```