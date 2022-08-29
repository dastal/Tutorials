package App;

public class AccessModifiers {
	
	public static void accessModifiers(String [] args) {
		
		// example
		Song holiday = new Song("Holiday", "Green Day", 300);
		
		// public: anything can access it
		
		// private: the method/variable/constructor is only accessible from inside the class
		// variables are usually set private, but the access to it is guaranteed by getters and setters
		
		// protected: allows the attribute/class only by other java programs/classes etc. inside the same package
		// package: folder where we are storing all the have files we want to keep together
	}
}
