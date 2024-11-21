import 'dart:math';
import 'dart:io';

void main () {
  List<int> primeNumbers = [1, 2, 3, 5, 7, 11, 14, 15];
  // index:                   0  1  2  3  4  5   6   7

  // Other Examples:
  List<String> germanNames = ['Wolfgang', 'Horst', 'Dieter'];
  List<bool> correct = [true, false, true, true, false];

  print(
      primeNumbers
  );

  print(
    primeNumbers.length
  );

  print(
    primeNumbers[0]
  );

  primeNumbers[6] = 13;

  print(
    primeNumbers
  );

  print(
      primeNumbers[0] + primeNumbers[1]
  );

  primeNumbers.add(17);

  print(
      primeNumbers
  );

  primeNumbers.remove(15);

  print(
      primeNumbers
  );

  print(
      primeNumbers.indexOf(11)
  );

  print(
      primeNumbers.indexOf(19)
  );

  print(
      primeNumbers.contains(11)
  );

  print(
      primeNumbers.contains(19)
  );

  print(
      germanNames
  );

  print(
      correct
  );
}
