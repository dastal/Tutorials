# Declare Command #

The declare command is a built in command in bash that allows to update attributed that are applied to variables within the scope of the shell.

With the command `declare -p` in the terminal it is possible to view all the variables that are already declared.

To declare a variable, just type `declare variable_name=[value]`. To change its value just type `declare variable_name=[other_value]`.

## Readonly Variables

To declare a readonly variable, use the tag `-r`:

```
declare -r variable_name=[value]
```