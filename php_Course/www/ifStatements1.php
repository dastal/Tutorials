<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      $isMale = true;

      if ($isMale){
        echo "You are male.";
      }

      echo "<br>";

      $isMale = false;

      if ($isMale){
        echo "You are male.";
      } else {
        echo "You are not male.";
      }

      echo "<br>";

      $isMale = false;
      $isTall = true;

      if ($isMale && $isTall){
        echo "You are a tall male.";
      } else {
        echo "You are not male or not tall.";
      }

      echo "<br>";

      $isMale = true;
      $isTall = false;

      if ($isMale && $isTall){
        echo "You are either tall or you are a male or both.";
      } elseif ($isMale && !$isTall){
        echo "You are a short male.";
      } else {
        echo "You are not male and not tall.";
      }

      $isMale = false;
      $isTall = true;

      echo "<br>";

      if ($isMale && $isTall){
        echo "You are either tall or you are a male or both.";
      } elseif ($isMale && !$isTall){
        echo "You are a short male.";
      } elseif (!$isMale && $isTall) {
        echo "You are not male but you are tall.";
      } else {
        echo "You are not male and not tall.";
      }

     ?>

  </body>
</html>
