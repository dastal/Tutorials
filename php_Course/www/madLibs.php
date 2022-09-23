<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <form action="madLibs.php" method="get">
      Enter a Color: <input type="text" name="color" value="red">
      <br>
      Enter a plural Noun: <input type="text" name="pluralNoun" value="Violets">
      <br>
      Enter a Celebrity: <input type="text" name="celebrity" value="you">
      <br>
      <input type="submit">
    </form>

    <br><br>

    <?php
      $color = $_GET["color"];
      $pluralNoun = $_GET["pluralNoun"];
      $celebrity = $_GET["celebrity"];

      echo "Roses are $color, <br>";
      echo "$pluralNoun are blue, <br>";
      echo "I love $celebrity. <br>";
     ?>

  </body>
</html>
