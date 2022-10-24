# String Porcessing #

## Comparison ##
To compare strings, use the following operators:

- `""` compares if two strings are equal
- `\>`, `\<` compares the lexicographical length of two strings

## Concatenation ##
To concatenate two strings, just prceed as follows:

```
concatenation=$string1$string2$string3
```

The concatenation is done by writing the strings one by one and by using the `$`-sign before every new string.

## Uppercase and Lowercase ##
The following commands show the upper- and lowercase operations that can be done to strings:

- `${string1,,}`: all the characters are converted into lowercase letters
- `${string1^^}`: all the characters are converted into uppercase letters
- `${string1^}`: The first letter of the string is converted into an uppercase letter
- `${string1^^r}`: All the `r`s in the string are converted into uppercase `R`s