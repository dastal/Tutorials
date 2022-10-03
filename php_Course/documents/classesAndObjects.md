# Classes And Objects #

Custom data types that allow us to model real world problems. A class is basically just a blueprint of a specific object. Instances of this class are then single pieces of that class.

The template of a class looks as follows:

```
class ClassName {
	var $variable1;
	var $variable2;
	var $variable3;
}
```

An instance of this class looks as follows:

```
class1 = new ClassName();
$class1->variable1 = "x";
$class1->variable2 = "y";
$class1->variable3 = "z";
```

And finally, accessing the attributes of this class, for example printing them out:

```
echo class1->variable1;
```