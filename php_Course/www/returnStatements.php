<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      function cube($num){
        return $num * $num * $num;
      }

      $cubeResult = cube(4);
      echo $cubeResult;

      echo "<br>";

      echo cube(5);

     ?>

  </body>
</html>
