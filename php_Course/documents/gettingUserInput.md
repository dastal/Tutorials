# Getting User Input #

Form: HTML element that allows the user to enter input information and that passes this input further to the PHP program. It has the following form:

```html
<form action="gettingUserInput.php" method="get">
</form>
```

whereas `action` is meant for which page (.php here) it is meant and `method` is meant for the get or the post method.

Inside the form, we can insert boxes where the user can type the input:

```html
<form action="gettingUserInput.php" method="get">
    Name: <input type="text" name="name">
    <br>
    Age: <input type="number" name="age">
    <input type="submit">
</form>
```

Note that every input box has its own name, text has `type="text"` and numbers have `type="number"`

To access the input afterwards, use:

```html
<?php echo $_GET["name"] ?>
<?php echo $_GET["age"] ?>
```

whereas the variables are called by their names.