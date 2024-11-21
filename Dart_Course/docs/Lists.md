# Lists #

In the case that we multiple pieces of related information in the same container, we can use lists / arrays.

Examples:

```javascript
List<int> primeNumbers = [1, 2, 3, 5, 7, 11, 13];
List<String> germanNames = ['Wolfgang', 'Horst', 'Dieter'];
List<bool> correct = [true, false, true, true, false];
```

The data type in this case is a list, `<int>` is the type of data that we're going to store in this list and the square brackets and its content are the actual list of data.

*Accessing Data from Lists*
Data inside lists can be accessed by using the index position of the list, starting at 0.

```javascript
primeNumbers[0]
```

*Other useful Functions*
* `list.length`
* Adding: `list.add(<item>)`
* Removing (by value): `list.remove(<item>)`
* Getting the index of an element: `list.indexOf(<item>)` (if the element doesn't exist then we get the result -1)
* Contains: `list.contains(<item>)` (Result: true/ false)
