<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      echo max(3, 6);

      echo "<br>";

      function getMax($num1, $num2) {
        if($num1 >= $num2) {
          return $num1;
        } else {
          return $num2;
        }
      }

      echo getMax(3,90);
      echo "<br>";
      echo getMax(90,3);
      echo "<br>";
      echo getMax(3,3);

      function getMax3($num1, $num2, $num3) {
        if($num1 >= $num2 && $num1 >= $num3){
          return $num1;
        } elseif($num2 >= $num1 && $num2 >= $num3) {
          return $num2;
        } else {
          return $num3;
        }
      }

      echo "<br>";
      echo getMax3(300, 90, 40);
      echo "<br>";
      echo getMax3(300, 900, 40);
      echo "<br>";
      echo getMax3(300, 90, 400);
      echo "<br>";
      echo getMax3(300, 90, 300);
      echo "<br>";
      echo getMax3(300, 300, 40);
      echo "<br>";
      echo getMax3(300, 300, 300);
    ?>

  </body>
</html>
