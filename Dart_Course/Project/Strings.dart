void main() {

  String greeting = "Hello ";
  String greeting2 = "World";

  print(greeting);

  print(greeting.length);
  print(greeting[3]);
  print(greeting.toUpperCase());
  print(greeting.toLowerCase());
  print(greeting.indexOf("e"));
  print(greeting.contains("e"));

  print(greeting + greeting2);
  print("The greeting is: ${greeting + greeting2}");
}