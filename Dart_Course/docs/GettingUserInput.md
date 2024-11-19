# Getting User Input #

First we need to import a low level input-output library to get the basic I/O functions of Dart:

´´´javascript
import 'dart:io';
´´´

Following code snippet to explain the input functionaltiy of Dart:

´´´javascript
print("What is your name?");
String? username = stdin.readLineSync();
print("Hello ${username}!");
´´´

´stdin´ is the standard input stream of dart.
´readLineSync()´ reads the line from the standard input.