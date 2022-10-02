# Including HTML #

About the include statement in PHP, which allows to include an external file. For example if we have a large number of pages on the website and we do not want to create the header and footer part seperately on each page. 
Therefore, we can use the include function, which allows us to include a file that contains the design of the header and footer on every page.

The template code looks as follows:

```
<?php
	include "header.html";
?>
<p>Some paragraphs or whatever</p>
<?php
	include "footer.html";
?>
```

The advantage of seperate headers and footers is that we don not have to change the header and the footer on every single page, but only in the respective file, without changing any of the page's code.