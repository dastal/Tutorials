package App;

public class ExponentMethod {
	public static void exponentMethod(String [] args) {
		
		System.out.println( pow(3,2) );
		System.out.println( pow(4,3) );
		
	}
	
	public static int pow(int basis, int power) {
		int result = 1;
		
		for(int i=0; i<power; i++) {
			result = result * basis;
		}
		
		return result;
	}
}
