package App;

public class MainMethodsAndNonStaticMethods {
	public static void mainMethodsAndNonStaticMethods(String [] args) {
		
		sayHi("Horst");
		
		// if we want to access sysBye, we need an instance of the main class
		MainMethodsAndNonStaticMethods App = new MainMethodsAndNonStaticMethods();
		App.sayBye("Horst");
		
	}
	
	// if main is static, sayHi must also be static
	public static void sayHi(String name) {
		System.out.println("Hello " + name + ".");
	}
	
	public void sayBye(String name) {
		System.out.println("Bye " + name + ".");
	}
}
