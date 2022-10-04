# Object Functions #

Object Functions are functions within a object. The template is as follows:

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

	function objectFunction(){
		do soemthing;
		return something;
	}
}
```

To call this new function, do the instantiation, then call it as follows: 

```
$newClassName = new className(variable1, variable2, variable3);
$newClassName->objectFunction();
```