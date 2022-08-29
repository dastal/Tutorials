package App;

import java.util.Scanner;

public class GuessingGame {
	public static void Guessing_Game(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		String secretWord = "Java";
		String guess = "";
		int guessCount = 0;
		int guessLimit = 3;
		boolean outOfGuesses = false;
		
		while(!guess.equals(secretWord) && !outOfGuesses) {
			if(guessCount < guessLimit) {
				System.out.print("Enter a guess: ");
				guess = keyboardInput.nextLine();
				guessCount++;
			} else {
				outOfGuesses = true;
			}
		}
		
		if(outOfGuesses) {
			System.out.println("You lose! You have no more guesses left.");
		} else {
			System.out.println("You win!");
		}
	}
}
