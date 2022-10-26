# Arrays #
To set an array, proceed as follows:

```
array=('value1' 'value2' 'value3')
```

Mind that there are no commas or else to separate the different values, simply use a whitespace between two values to separate them.

To get the wohle array, e.g. for prining it out, use the following command:

```
echo "${array[@]}"
```

To get a single value from the array, for example the first value in the array, use the following command:

```
echo "${array[0]}"
```

Mind that the indexing of an array starts at 0.

To get the indexes of the occupied values within the array, e.g. for printing it out, use:

```
echo "${!array[@]}"
```

To get the length of the array, use:

```
"${#array[@]}"
```

To remove an element of the array, for example the element at the second index of the array, use:

```
unset array[2]
```

To add an element to the array, for example at the second index, use:

```
array[2]="some_value"
```