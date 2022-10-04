# Inheritance #

Assuming we want a class that can do everything another class can do, but also some more things. 
Inheritance makes sure that we can reuse all the things of a super-class inlcuding new things in a sub-class.

```
class className {
	function function1(){
		do something;
	}
}

class subClassName extends className {
	function function2(){
		do something;
	}
}
```

Mind that the word `extends` means that `subClassName` inherits from `className`.

## Overriding Functions ##
We can also override a function in the sub-class. Therefore look at the following code snippet.

```
class className {
	function function1(){
		do something;
	}
}

class subClassName extends className {
	function function1(){
		do something different than the original function1;
	}
}
```

We can see that the function has exactly the same name in both classes. This means that `function1` in the sub-class overrides the original function `function1`. 