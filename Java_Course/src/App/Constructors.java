package App;

public class Constructors {
	public static void constructors(String [] args) {
		
		Book2 book1 = new Book2("Harry Potter", "JK Rowling", 500, "English");
				
		Book2 book2 = new Book2("The Lord of the Rings", "JRR Tolkien", 1000, "English");
		
		System.out.println(book1.title);
		System.out.println(book2.pages);
	}
}
