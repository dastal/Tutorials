# Variables #

It is possible to use Variables in PHP. Every time we want to use a variable, we need to start with a `$` sign. For example:

```php
$characterName = "John";
$characterAge = 70;
```

For a string, like mostly always we use quotation marks, whereas numbers (integers and floats) can be written without quatation marks.

In order to call the desired variable in an echoed string, just type `$[variable]` at the desired position in the string. Example:

```php
echo "There once was a man named $characterName <br>";
echo "He was $characterAge years old <br>";
```