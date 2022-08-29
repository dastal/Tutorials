package App;

public class Numbers {
	public static void numbers(String [] args) {
		
		System.out.println( 3 + 4 );
		System.out.println( 3 - 2 );
		System.out.println( 3 * 4 );
		System.out.println( 3 / 4 );		//dividing two integers returns also an integer

		System.out.println();
		
		System.out.println( 3.0 + 4.0 );
		
		System.out.println();
		
		System.out.println( 10 % 3 );
		
		System.out.println();
		
		int myInt = 3;
		double myDouble = 5.5;
		
		System.out.println( myInt + 5 );
		System.out.println( myInt + myDouble );
		
		System.out.println();
		
		double myNegDouble = -5.5;

		System.out.println( Math.abs(myNegDouble) );
		System.out.println( Math.pow(myInt, 3) );
		System.out.println( Math.sqrt(36) );
		System.out.println( Math.min(2, 6) );
		System.out.println( Math.max(2, 6) );
		System.out.println( Math.round(myDouble) );
		System.out.println( Math.random());
		
		System.out.println();
	}
}
