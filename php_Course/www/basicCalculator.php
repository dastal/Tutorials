<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <form action="basicCalculator.php" method="get">
      First Number: <input type="number" name="num1" value="0">
      <br>
      Second Number: <input type="number" name="num2" value="0">
      <input type="submit">
    </form>

    Answer: <?php echo $_GET["num1"] + $_GET["num2"]?>

  </body>
</html>
