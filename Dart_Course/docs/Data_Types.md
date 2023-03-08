
# Data Types #
Strongly typed language: The type of a variable is known at compile time, for example C++, Java, Swift

Dynamic typed language: the type of a vairbale is known at run time, for example Python, Ruby, Javascript.

In Dart there are fice basic types of variables:
- `int`
- `double`
- `String`
- `bool`
- `dynamic`

The first four are fundamental types and `dynamic` means that we van change the value at runtime. For example: If we use:

```javascript
var amount = 100;
```

then, at compile time, Dart interprets it as an integer. But, the next time that we assign another value different than an integer to `amount`, we will get an error. If we use the type `dynamic`, then we are able to assign different types to the same variable:

```javascript
dynamic weakVariable = 100;
weakVariable = 'Dart Programming';
```