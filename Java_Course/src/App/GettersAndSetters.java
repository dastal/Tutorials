package App;

public class GettersAndSetters {
	public static void gettersAnsSetters(String [] args) {
		
		Movie movie1 = new Movie("The Avengers", "Joss WEhedon", "PG-13");
		Movie movie2 = new Movie("Step Brothers", "Adam McKay", "R");
		
		// not possible anymore:
		// System.out.println(movie1.rating);
		
		movie1.setRating("Dog");
		
		System.out.println(movie1.getRating());
		
		movie1.setRating("PG-13");
		
		System.out.println(movie1.getRating());
		System.out.println(movie2.getTitle());
		System.out.println(movie1.getDirector());		
	}
}
