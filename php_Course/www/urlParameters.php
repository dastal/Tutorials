<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <form action="urlParameters.php" method="get">
      Name: <input type="text" name="name"> <br>
      <input type="submit">
    </form>

    <br>

    <?php
      echo $_GET["name"];
      echo "<br>";
      echo $_GET["age"];
     ?>

  </body>
</html>
