# Working with Strings #

A string is always inside of two quatation marks:

```
# in a variable
phrase = "Python Course"
print(phrase)

# Concatenation
print(phrase + " is very good")

# in a print statement
print("Python Course")
```

Sometimes, special signs inside of the string need a `\`:
- `\n` new line inside of the string
- `\"` quotation mark inside of the string (without, python would just see this as an ended string)
- `\` normal backslash

Some operations that can be applied to strings:
- `phrase.lower()` all the characters of the string are converted to lower case
- `phrase.upper()` all the characters of the string are converted to upper case
- `phrase.isupper()` checks if all the characters of a string are uppper case, returns `true` or `false`
- `phrase.islower()` checks if all the characters of a string are lower case, returns `true` or `false`
- `len(phrase)` checks the length of the string (how many characters are in the string)
- `phrase[0]` Gives back the chrachter that is located at index 0.
- `phrase.index("P")` Gives back the index where the specific character is located, if the character is not inside the string, the function will return false
- `phrase.index("Course")` Gives back the inndex where sequence starts
- `phrase.replace("Tutorial", "Course")` replaces the sequence with another sequence