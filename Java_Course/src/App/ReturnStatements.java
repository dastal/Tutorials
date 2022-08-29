package App;

import java.util.Scanner;

	public class ReturnStatements {
	public static void returnStatements(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		System.out.println( cube(3) );
		
		int myNum = cube(2);
		
		System.out.println(myNum);
		
		System.out.println();
	}
	
	public static int cube(int num) 
	{
		return (num* num * num);
	}
}
