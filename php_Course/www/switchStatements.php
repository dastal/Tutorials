<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <form action="switchStatements.php" method="post">
      What was your grade?
      <input type="text" name="grade">
      <input type="submit">
    </form>

    <?php
      $grade = $_POST["grade"];

      switch($grade){
        case "A":
          echo "You did amazing!";
          break;
        case "B":
          echo "You did pretty good!";
          break;
        case "C":
          echo "You did poorly.";
          break;
        case "D":
          echo "You did very bad.";
          break;
        case "F":
          echo "YOU FAIL!";
          break;
        default:
          echo "Invalid Grade";
          break;
      }
     ?>

  </body>
</html>
