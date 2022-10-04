<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php

      class Chef {
        function makeChicken(){
          echo "The chef makes chicken. <br>";
        }
        function makeSalad(){
          echo "The chef makes salad. <br>";
        }
        function makeSpecialDish(){
          echo "The chef makes bbq ribs. <br>";
        }
      }

      class ItalianChef extends Chef {
        function makePasta(){
          echo "The chef makes pasta. <br>";
        }
        function makePizza(){
          echo "The chef makes pizza. <br>";
        }
        function makeSpecialDish(){
          echo "The chef makes chicken parm. <br>";
        }
      }

      $chef = new Chef();
      $chef->makeChicken();

      $italianChef = new ItalianChef();
      $italianChef->makeChicken();
      $italianChef->makePasta();
      $italianChef->makePizza();

      $chef->makeSpecialDish();
      $italianChef->makeSpecialDish();
     ?>

  </body>
</html>
