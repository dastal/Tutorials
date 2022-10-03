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

      function __construct($number){
        echo "New Book with number $number created. <br>";
      }
    }

    $book1 = new Book(001);
    $book1->title = "Harry Potter";
    $book1->author = "J.K. Rowling";
    $book1->pages = 400;

    $book2 = new Book(002);
    $book2->title = "Lord of the Rings";
    $book2->author = "Tolkien";
    $book2->pages = 700;

    class nextBook{
      var $title;
      var $author;
      var $pages;

      function __construct($aTitle, $aAuthor, $aPages){
        $this->title = $aTitle;
        $this->author = $aAuthor;
        $this->pages = $aPages;
      }
    }

    $nextBook1 = new nextBook("Harry Potter", "J.K. Rowling", 400);
    $nextBook2 = new nextBook("The Lord of the Rings", "Tolkien", 700);


    echo "<br><br><br>";

    echo $nextBook1->title;
    echo "<br>";
    echo $nextBook2->title;
    echo "<br>";

     ?>

  </body>
</html>
