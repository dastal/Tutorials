# URL Parameters #

After submitting the form, the value gets placed inside of the URL. This is called a URL parameter and they can be changed by changing the URL and without entering the information into the textbox.
The URL parameters are handed in within the URL, e.g.

```
http://localhost:4000/urlParameters.php?name=Dave
```

They are "separated" from the website URL by a `?`. If we want to hand in more parameters, we can do that by adding a `&` followed by the further parameter, e.g.

```
http://localhost:4000/urlParameters.php?name=Dave&age=31
```

So basically we can hand in a parameter without using an input box and a submit button and the program would still be able to read the parameter.