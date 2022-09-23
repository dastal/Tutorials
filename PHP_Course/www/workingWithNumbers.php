<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      echo "PHP Tutorial";

      echo "<br>";

      $phrase = "Hello There.";
      echo $phrase;

      echo "<br>";

      echo strtolower($phrase);

      echo "<br>";

      echo strtoupper($phrase);

      echo "<br>";

      echo strlen($phrase);

      echo "<br>";

      echo $phrase[0];
      echo $phrase[2];
      echo "Dave"[1];

      echo "<br>";

      $phrase[0] = "B";
      echo $phrase;
      $phrase[0] = "H";

      echo "<br>";

      echo str_replace("Hello", "Bye", $phrase);

      echo "<br>";

      echo substr($phrase, 6);
      echo "<br>";
      echo substr($phrase, 0, 5)
     ?>

  </body>
</html>




