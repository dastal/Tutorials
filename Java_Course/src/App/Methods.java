package App;

import java.util.Scanner;

public class Methods {
	public static void methods(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		sayHi();
		sayHi2("Dave");
		sayHi2("Chris");
		
		String myName = "Dave";
		
		sayHi2(myName);
		
		sayHi3("Dave", 29);
		
		System.out.println();
	}
	
	public static void sayHi() 
	{
		System.out.println("Hello User!");
	}
	
	public static void sayHi2(String name) 
	{
		System.out.println("Hello " + name + "!");
	}
	
	public static void sayHi3(String name, int age) 
	{
		System.out.println("Hello " + name + ", you are " + age + " years old.");
	}
}
