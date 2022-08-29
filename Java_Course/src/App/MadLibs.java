package App;

import java.util.Scanner;

public class MadLibs {
	public static void madLibs(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		System.out.print("Enter a color: ");
		String color = keyboardInput.nextLine();
		System.out.print("Enter a plural Noun: ");
		String pluralNoun = keyboardInput.nextLine();
		System.out.print("Enter a celebrity: ");
		String celebrity = keyboardInput.nextLine();
		
		System.out.println("Roses are " + color  + "\n"
							+ pluralNoun + " are blue\n"
							+ "I love " + celebrity + ".");	
		
		System.out.println();
	}
}
