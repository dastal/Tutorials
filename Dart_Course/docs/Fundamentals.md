# Fundamentals #
Dart is a static type programming language (a language where types must be indicated by the programmer). It is also a campiled programming language (compiled, tranlators that generate machine code from source code). 

Dart supports two types of compilation:
- AOT (Ahead of time, compiling a higher-level programming language into a lower-level language before execution to reduce the amount of work needed the be performed at runtime)
- JIT (Just in time, compiling the code in time)

When we want to run a program, we first have to compile it and then run it. When we run a program, then it is automatically compiled on the fly (JIT). But when we deploy our program then it is first compiled and then it is run (AOT).

When we write a dart program, every program starts with the main function:

```
void main() {

}
```

As always, void means that the function returns nothing, so if there is no return type, then we use void (bit it is optional). If we assign a string to a type `var`, then dart automatically recognizes that the variable is a string and treats it as a string (Type inferrence). But if we want to assign an integer to a type `String`, we will get an error.  <u>So the type `var` supports type inferrence.</u>  To have a basic collection of types, import the [dart:core](https://api.dart.dev/stable/2.19.4/dart-core/dart-core-library.html) package. 

## Getting Input from the User ##
To get input from the user, we can use the following code:

```js
import 'dart:io';

main() {
  stdout.writeln('What is your name? ');
  String? name = stdin.readLineSync();
  print('My name is $name');
}
```

- `stdout.writeln('What is your name? ')` is used for first writing something to the terminal and then reading the following line into `this`
- `stdin.readLineSync()` is used for reading the input from `this` and saving it inot a variable, `String` in this case
- `String?` is defined here since dart 3 has a "Null Safety" that is used to assure that the input cannot be null. If we would not use the `?` after the type, this would be applied.
- To add the string into a another string, use `$` followed by the variable

## Comments ##
To add comments into a dart file, we can use:

- Inline comments `//`
- Block Comments `/* */`
- Documentation `///`

