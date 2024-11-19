import 'dart:math';
import 'dart:io';

void main () {
  print("What is your name?");
  String? username = stdin.readLineSync();
  print("Hello ${username}!");
}
