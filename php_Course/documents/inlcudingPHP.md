# Including PHP #

Example: we are designing a blog site and every page should have the same look. So we create a PHP file (in this case "article-header.php") and code there the elements that every page shall have.
Then, for every page we can now use this header file and sepcify the required values directly on every seperate page.

The template looks as follows:

```
include "article-header.php";
```

Also functions and variables can be declared on the external PHP file and the be used on the actual page.