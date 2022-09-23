<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

     <form action="gettingUserInput.php" method="get">
       Name: <input type="text" name="name">
       <br>
       Age: <input type="number" name="age">
       <input type="submit">
     </form>
     <br>
     Hi, <?php echo $_GET["name"] ?>,
     you're <?php echo $_GET["age"] ?> years old.

  </body>
</html>
