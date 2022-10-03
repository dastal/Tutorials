<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      class Book {
        var $title;
        var $author;
        var $pages;
      }

      $book1 = new Book();
      $book1->title = "Harry Potter";
      $book1->author = "J.K. Rowling";
      $book1->pages = 400;

      echo $book1->title;
      echo "<br>";
      echo $book1->author;
      echo "<br>";

      $book2 = new Book();
      $book2->title = "Lord of the Rings";
      $book2->author = "Tolkien";
      $book2->pages = 700;

      echo $book2->title;
      echo "<br>";
      echo $book2->author;
     ?>

  </body>
</html>
