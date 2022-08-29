package App;

public class Bird implements Animal {

	@Override
	public void speak() {
		System.out.println("Tweet tweet!");
	}

	@Override
	public void eat() {
		System.out.println("Eats a worm.");
	}

}
