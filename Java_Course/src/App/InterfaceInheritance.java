package App;

public class InterfaceInheritance {

	public static void interfaceInheritance(String [] args) {
		
		Cow myCow = new Cow();
		myCow.eat();
		
		Dog myDog = new Dog();
		myDog.speak();
		
		// but since the interface Animal implements them all, we can also use
		Animal myCat = new Cat();
		myCat.speak();
		
		Animal myBird = new Bird();
		myBird.eat();
		
		Animal [] animals = {
				new Cow(),
				new Cat(),
				new Dog(),
				new Bird()
		};
		
		System.out.println();
		
		for(int i=0;i<animals.length;i++) {
			animals[i].eat();
		}
		
		System.out.println();
		
		for(int i=0;i<animals.length;i++) {
			animals[i].speak();
		}
	}
}
