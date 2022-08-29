package App;

public class ObjectAndInstanceMethods {
	public static void main(String [] args) {
		
		Student2 myStudent = new Student2("Dave", "Software Systems", 3.2);
		
		Student2 myStudent2 = new Student2("Jimmy", "Business and Administration", 4.2);
		
		System.out.println(myStudent.isOnHonorRoll() );
		
		System.out.println(myStudent2.isOnHonorRoll() );
	}
}
