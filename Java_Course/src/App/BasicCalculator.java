package App;

import java.util.Scanner;

public class BasicCalculator {
	public static void basicCalculator(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		System.out.print("Enter the first number: ");
		double num1 = keyboardInput.nextDouble();
		
		System.out.print("Enter the second number: ");
		double num2 = keyboardInput.nextDouble();
		
		double result = num1 + num2;
		System.out.println("The result is: " + result);
		
		
		System.out.println();
	}
}
