# Using Checkboxes #

The templateof a checkbox is as follows:

```
<input type="checkbox" name="variable" value="value">
```

If we want to use multiple checkboxes, we can use the following template:

```
<input type="checkbox" name="array[]" value="value1">
<input type="checkbox" name="array[]" value="value2">
<input type="checkbox" name="array[]" value="value3">
...
```

This stores all the values that the user enters in the array. This array can then be accessed in PHP to furhter process them.

