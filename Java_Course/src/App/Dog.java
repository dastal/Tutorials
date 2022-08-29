package App;

public class Dog implements Animal {

	@Override
	public void speak() {
		System.out.println("Wuff wuff!");
	}

	@Override
	public void eat() {
		System.out.println("Eats some kibble.");
	}

}
