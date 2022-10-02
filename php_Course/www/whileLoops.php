<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      $index = 1;

      while($index <= 5){
        echo "$index <br>";
        $index++;
      };

      echo "<br><br>";

      do{
        echo "$index <br>";
        $index--;
      }while($index > 1);
     ?>

  </body>
</html>
