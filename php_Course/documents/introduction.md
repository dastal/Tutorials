# Introduction #

## Setup ##

Using PHP requires a Web Server. To create suche a Web Server, open the command line (Windows) and enter

```
php -S localhost:4000
```

Ideally, open the server in the folder where you created your project to have a shorter URL to the projcet.

This is a basic Web Server that is ideal for learning the basics of PHP. Leave it run during the programming tasks.

## Hello World ##
In Atom, open the project folder and insert a new File (helloWorld.php in this case).

In a PHP File, it is possible to write HTML code and PHP code. To start with the typical "Hello World" task, enter

```html
<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

    <?php
      echo("Hello World");
    ?>

  </body>
</html>
```

This code will print "Hello World to your browser.

To run this file, simply open your browser (Google Crome in this case) and enter

```
localhost:4000/[path to your file]
```

Now there should "Hello World" appear on your browser.


