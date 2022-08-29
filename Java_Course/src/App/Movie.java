package App;

public class Movie {
	// Making rating private means that the rating can only be accessed by the movie class -> setter
	private String title;
	private String director;
	private String rating;
	
	public Movie(String title, String director, String rating) {
		this.setTitle(title);
		this.setDirector(director);
		this.setRating(rating);
	}
	
	public void setTitle(String title) {
		this.title = title;
	}
	
	public String getTitle() {
		return title;
	}
	
	// Rating has only the values G, PG, PG-13, R, NR -> getters and setters
	public void setRating(String rating) {
		if(rating.equals("G") || rating.equals("PG") || rating.equals("PG-13") || rating.equals("R") || rating.equals("NR")){
			this.rating = rating;
		} else {
			this.rating = "NR";
		}
	}
	
	public String getRating() {
		return rating;
	}
	
	public void setDirector(String director) {
		this.director = director;
	}
	
	public String getDirector() {
		return director;
	}
}
