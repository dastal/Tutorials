package App;

public class NestedLoopsAnd2DArrays {
	public static void nestedLoopsAnd2DArrays(String [] args) {
		
		// 2D Array: 2 ways of defining them
		int [][] numberGrid1 = new int[3][4];
		
		int [][] numberGrid2 = {
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9},
				{0}
		};
		
		System.out.println(numberGrid2[0][0]);
		System.out.println(numberGrid2[1][2]);
		
		System.out.println();
		
		
		// Nested Loop
		for(int i=1; i<3; i++) {
			for(int j=1; j<4; j++) {
				System.out.println("i=" + i + ", j=" + j);
			}
		}
		
		System.out.println();
		
		
		// Nested for-loop capable of printing out all the elements of the 2d array
		for(int i=0; i<numberGrid2.length; i++) {
			for(int j=0; j<numberGrid2[i].length; j++) {
				System.out.print(numberGrid2[i][j]);
			}
			System.out.println();
		}
		
	}
}
