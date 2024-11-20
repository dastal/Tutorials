import 'dart:math';
import 'dart:io';

void main () {
  // Integers
  print("Enter first number: ");
  String? num1 = stdin.readLineSync();
  print("Enter second number: ");
  String? num2 = stdin.readLineSync();

  print(
      int.parse(num1!) + int.parse(num2!)
  );

  // Doubles
  print("Enter first number: ");
  String? num3 = stdin.readLineSync();
  print("Enter second number: ");
  String? num4 = stdin.readLineSync();

  print(
      double.parse(num3!) + double.parse(num4!)
  );

  // Parsing input
  print("Enter first number: ");
  double num5 = double.parse(stdin.readLineSync() ?? '0');
  print("Enter second number: ");
  double num6 = double.parse(stdin.readLineSync() ?? '0');

  print(
      num5 + num6
  );
}
