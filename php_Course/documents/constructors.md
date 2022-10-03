# Constructors #

A function that we can implement into a class and which gets called when we instantiate the class.

The template looks as follows:

```
class className{
      var $variable1; 
	var $variable2;
      var $variable3;

	function __construct($variable1, $variable2, $variable3){
		echo "Something";
	}
}
```

The contructor must be called `__construct()`! This would print out the word "Something" every time a new class is instantiated.

We can also hand in variables to the constructor to simplify the instantiation of a class:

```
class className{
      var $variable1; 
	var $variable2;
      var $variable3;

	function __construct($variable1, $variable2, $variable3){
		$this->variable1 = $variable1;
		$this->variable2 = $variable2;
		$this->variable3 = $variable3;
	}
}
```

And then to actually instantiate the class:

```
$newClassName = new className(variable1, variable2, variable3);
```

