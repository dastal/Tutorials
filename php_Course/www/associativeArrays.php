<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>
    <form action="associativeArrays.php" method="post">
      <input type="text" name="student" value="">
      <input type="submit">
    </form>
    <br>

    <?php
      $grades = array("Jim"=>6, "Pam"=>5.25, "Oscar"=>4.5);
      echo $grades["Jim"];
      echo "<br>";
      echo $grades["Pam"];
      echo "<br>";
      echo $grades["Oscar"];
      echo "<br>";
      echo count($grades);
      echo "<br>";

      echo $grades[$_POST["student"]];
    ?>
  </body>
</html>
