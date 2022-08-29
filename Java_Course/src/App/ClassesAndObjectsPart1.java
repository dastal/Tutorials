package App;

public class ClassesAndObjectsPart1 {
	public static void classesAndObjectsPart1(String [] args) {
		
		Student myStudent = new Student();
		myStudent.firstName = "Clark";
		myStudent.lastName = "Kent";
		myStudent.major = "Aviation";
		myStudent.gpa = 6.0;
		myStudent.age = 30;
		myStudent.onProbation = false;
		
		System.out.println(myStudent.firstName);
		System.out.println(myStudent.lastName);
		System.out.println(myStudent.major);
		System.out.println(myStudent.gpa);
		System.out.println(myStudent.age);
		System.out.println(myStudent.onProbation);
		
		System.out.println();
		
		Student myStudent2 = new Student();
		myStudent2.firstName = "Tony";
		myStudent2.lastName = "Stark";
		myStudent2.major = "Mechanical Engineering";
		myStudent2.gpa = 6.0;
		myStudent2.age = 40;
		myStudent2.onProbation = true;
		
		System.out.println(myStudent2.firstName);
		System.out.println(myStudent2.lastName);
		System.out.println(myStudent2.major);
		System.out.println(myStudent2.gpa);
		System.out.println(myStudent2.age);
		System.out.println(myStudent2.onProbation);
	}
}
