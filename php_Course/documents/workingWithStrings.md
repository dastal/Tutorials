# Working With Strings #

A string can be printed out directly:

```html
echo "PHP Tutorial";
```

Instead, we can store it in a variable and then print the variable:

```html
$phrase = "Hello There.";
echo $prase;
```

## String Functions ##

### `strtolower` ###

Converts all the characters contained in a string to lower case letters.

```html
echo strtolower($phrase);
```

### `strtoupper` ###

Converts all the characters contained in a string to upper case letters.

```html
echo strtoupper($phrase);
```

### `strlen` ###

Counts the characters contianed in a string and returns the respective number.

```html
echo strlen($phrase);
```

### Single Character of a String ###

Get a single character of a string. The index counting starts at 0.

```html
echo $phrase[0];
echo $phrase[2];
echo "Dave"[1];

$phrase[0] = "B";
echo $phrase;
```

### `str_replace` ###

Replace a certain sequence that is contained in a string ###

```html
echo str_replace("Hello", "Bye", $phrase);
```

### `substr` ###

Get a certain sequence of a string using the index. The following sequence returns a the substring starting at the 6th chracter until the end

```html
echo substr($phrase, 6);
```

The following sequence returns the substring starting at the beginning and it returns 5 characters totally:

```html
echo substr($phrase, 0, 5);
```

There are a lot more of those functions.
