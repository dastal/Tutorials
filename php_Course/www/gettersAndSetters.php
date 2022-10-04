<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php

      class Movie {
        public $title;
        private $rating;

        function __construct($title, $rating){
          $this->title = $title;
          $this->setRating($rating);
        }

        function getRating(){
          return $this->rating;
        }

        function setRating($rating){
          if($rating == "G" || $rating == "PG" || $rating == "PG-13" || $rating == "R" || $rating == "NR"){
              $this->rating = $rating;
          } else {
            $this->rating = "NR";
            echo "Sorry, this is not a valid rating! The rating is automatically set to NR.<br>";
          }

        }
      }

      $avengers = new Movie("Avengers", "Dog");

      $avengers->setRating("Dog");
      $avengers->setRating("PG-13");
      echo "<br>";
      echo $avengers->getRating();
     ?>

  </body>
</html>
