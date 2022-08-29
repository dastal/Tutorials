package App;

public class Cat implements Animal {

	@Override
	public void speak() {
		System.out.println("Meow!");
	}

	@Override
	public void eat() {
		System.out.println("Eats a mouse.");
	}

}
