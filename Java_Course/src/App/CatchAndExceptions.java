package App;

import java.util.InputMismatchException;
import java.util.Scanner;

public class CatchAndExceptions {
	public static void catchAndExceptions(String [] args) {
		
		// In the following section, an exception is raised when a string is entered instead of a number.
		
		Scanner keyboardInput = new Scanner(System.in);
		System.out.print("Enter a number: ");
		
		// For the second example
		int [] nums = {1, 2, 3};		
		
		try {
			System.out.println(nums[5]);					// Second Example
			double num = keyboardInput.nextDouble();
			System.out.println(num);
		} catch(Exception e) {
			System.out.println("Invalid Input!");
			// We can also use Exception e instead (Prints out the first exception which happens in the try section)
			System.out.println(e);
		}
		
		// Catch one specific error
		try {
			System.out.println(nums[5]);
		} catch(ArrayIndexOutOfBoundsException e) {
			// This catches only ArrayIndexOutOfBoundsException
			System.out.println(e);
			/// but we can also add several catch statements
		} catch(InputMismatchException e) {
			System.out.println("Invalid Input!");
		} catch(Exception e) {
			System.out.println(e);
		} catch(Error e) {
			// For catching errors
		} catch (Throwable e) {
			// Errors (Throwable catches every error)
		}
			
	}
}
