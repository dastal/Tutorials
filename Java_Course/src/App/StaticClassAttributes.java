package App;

public class StaticClassAttributes {
	public static void staticClassAttributes(String [] args) {
		
		Song holiday = new Song("Holiday", "Green Day", 200);
		Song americanIdiot =  new Song("American Idiot", "Green Day", 168);
		
		System.out.println(holiday.getSongsCount());
		System.out.println(americanIdiot.getSongsCount());
		
		Song africa = new Song("Africa", "Toto", 300);
		
		System.out.println(holiday.getSongsCount());
		System.out.println(americanIdiot.getSongsCount());
		System.out.println(africa.getSongsCount());
	}
}
