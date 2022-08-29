package App;

public class StaticClassMethods {
	public static void staticClassMethods(String [] args) {
		
		// There is no need for 
		// Prints prints = new Prints();
		// while using static methods. Instead we can use:
		sayHi();
		Prints.sayGoodbye();
		System.out.println(Prints.feetInMile);
		
	}
	
	public static void sayHi() {
		System.out.println("Hi!");
	}
}
