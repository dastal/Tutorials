<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      $friends = array("Kevin", "Karen", "Oscar", "Jim", 1, false);
      echo $friends[0];
      echo "<br>";
      echo $friends[1];
      echo "<br>";
      $friends[1] = "Dwight";
      echo $friends[1];
      echo "<br>";
      $friends[6] = "Angela";
      echo $friends[6];
      echo "<br>";
      echo count($friends);
     ?>

  </body>
</html>
