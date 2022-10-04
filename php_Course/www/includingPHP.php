<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      $title = "Dave's Blog";
      $author = "Dave";
      $wordCount = 400;

      include "files/article-header.php";

      echo "<br><br><br>";

      include "files/useful-tools.php";
      sayHi("Dave");
      echo $feetInMile;
     ?>

  </body>
</html>
