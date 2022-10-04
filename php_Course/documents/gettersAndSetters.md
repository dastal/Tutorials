# Getters and Setters #

Getters and Setters can be used to limit the values that can be given to a class variable.

## Visibility Modifiers ##
Handles the visibility of a class vairable.

- `public`: everyone can access the variable
- `private`: Nobody can access the variable outiside of the class.

## Getter ##
Allows the user to get the private variable.

The template looks as follows (of course the getter must be inside the class):

```
class className{
	private $variable;
	
	function __construct($variable){
          $this->setVariable($variable);
        }

	function getVariable(){
		return $this->variable;
	}
}
```

Pay attention to the constructor function, there the setVariable fucntion must also be applied, otherwise the rules will not be applied during the instantiation.
Finally, accessing the variable outside of the class should look as follows:

```
$className->getVariable();
```

## Setter ##
Allows the user to set the private variable. It allows us to enforce rules of how the variable can be set.

The template looks as follows (of course the getter must be inside the class):

```
class className{
	private $variable;
	
	function __construct($variable){
          $this->variable = $variable;
        }

	function setVariable($rating){
		if (some rule is true){
			$this->variable = $variable;
		} else {
			Notify the user that the value is nor valid and that the variable cannot be set and set the variable to a default value.
		}
	}
}
```

And then accessing the variable outside of the class should look as follows:

```
$className->setVariable(some value);
```
