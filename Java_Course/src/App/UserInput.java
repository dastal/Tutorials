package App;

import java.util.Scanner;

public class UserInput {
	public static void userInput(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		System.out.print("Enter your name: ");
		String name = keyboardInput.nextLine();
		
		System.out.print("Enter your age: ");
		int age = keyboardInput.nextInt();
		
		System.out.println("Hey " + name + ", sou are " + age + " years old.");
		
		System.out.println();
	}
}
