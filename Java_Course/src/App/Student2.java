package App;

public class Student2 {
	String name;
	String major;
	double gpa;
	
	public Student2(String name, String major, double gpa) {
		this.name = name;
		this.major = major;
		this.gpa = gpa;
	}
	
	public boolean isOnHonorRoll() {
		if(this.gpa >= 3.5 ) {
			return true;
		} else {
			return false;
		}
	}
}
