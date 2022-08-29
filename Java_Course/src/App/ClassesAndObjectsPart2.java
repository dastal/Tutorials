package App;

public class ClassesAndObjectsPart2 {
	public static void classesAndObjectsPart2(String [] args) {
		
		Book book1 = new Book();
		book1.author = "JK Rowling";
		book1.title = "Harry Potter";
		book1.pages = 500;
		book1.language = "English";
		
		
		Book book2 = new Book();
		book2.author = "JRR Tolkien";
		book2.title = "The Lord of the Rings";
		book2.pages = 1000;
		book2.language = "English";
		
		System.out.println(book1.title);
		System.out.println(book2.pages);
	}
}
