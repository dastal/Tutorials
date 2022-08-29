package App;

public class SwitchStatements {
	public static void Switch_Statements(String [] args) {
		
		System.out.println( getDayName(0) );
		System.out.println( getDayName(1) );
		System.out.println( getDayName(2) );
		System.out.println( getDayName(3) );
		System.out.println( getDayName(4) );
		System.out.println( getDayName(5) );
		System.out.println( getDayName(6) );
		System.out.println( getDayName(10) );
		
	}
	
	public static String getDayName(int dayNum) {
		String dayName = "";
		
		// A switch statement is a "special type" of an if statement
		
		switch(dayNum) {
		case 0 :
			dayName = "Sunday";
			break;
		case 1:
			dayName = "Monday";
			break;
		case 2:
			dayName = "Tuesday";
			break;
		case 3:
			dayName = "Wednesday";
			break;
		case 4:
			dayName = "Thursday";
			break;
		case 5:
			dayName = "Friday";
			break;
		case 6:
			dayName = "Saturday";
			break;
		default:
			dayName = "Invalid day number!";
			break;
		}
						
		return dayName;
	}
}
