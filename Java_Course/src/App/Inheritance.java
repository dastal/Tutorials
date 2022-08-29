package App;

public class Inheritance {

	public static void inheritance(String [] args) {
		
		Chef normalChef = new Chef();
		normalChef.makeChicken();
		normalChef.makeSalad();
		normalChef.makeSpecialDish();
		
		ItalianChef italianChef = new ItalianChef();
		italianChef.makeSpaghetti();
		italianChef.makeChicken();
		italianChef.makeSpecialDish();
		
		ChineseChef chineseChef = new ChineseChef();
		chineseChef.makeFriedRice();
		chineseChef.makeChicken();
		chineseChef.makeSpecialDish();
	}
}
