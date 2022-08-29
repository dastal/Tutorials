package App;

import java.util.Scanner;

public class Arrays {
	public static void arrays(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		String [] friends = { "Bruce", "Tony Stark", "Yoda"};
		
		System.out.println(friends[0]);
		System.out.println( friends.length );
		
		friends[0] = "Bruce Wayne";
		System.out.println(friends[0]);
		
		String foes [] = new String[3];
		foes[0] = "King Pin";
		foes[1] = "Joker";
		System.out.println(foes[2]);
		foes[2] = "Thanos";
		
		System.out.println(foes[0]);
		
		System.out.println();
	}
}
