<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      function sayHi(){
        echo "Hello User.";
      }

      sayHi();

      echo "<br>";

      function sayHiSpec($name){
        echo "Hello $name. <br>";
      }

      sayHiSpec("Dave");
      sayHiSpec("Tom");
      sayHiSpec("Oscar");

      function sayHiAge($name, $age){
        echo "Hello $name, you are $age years old. <br>";
      }

      sayHiAge("Dave", 31);
      sayHiAge("Tom", 27);
      sayHiAge("Oscar", 25);
     ?>

  </body>
</html>
