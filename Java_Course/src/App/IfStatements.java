package App;

import java.util.Scanner;

public class IfStatements {
	public static void ifStatements(String [] args) {
		
		Scanner keyboardInput = new Scanner(System.in);
		
		boolean isMale = true;
		boolean isTall = true;
		
		if(isMale) 
		{
			System.out.println("You are male.");
		}
		
		isMale = false;
		
		if(isMale) 
		{
			System.out.println("You are male.");
		}
		else 
		{
			System.out.println("You are not male.");
		}
		
		isMale = true;
		
		if(isMale && isTall) 
		{
			System.out.println("You are a tall male.");
		}
		else if(!isMale && isTall) 
		{
			System.out.println("You are tall but you are not a male");
		}
		else if(isMale && !isTall) 
		{
			System.out.println("You are a short male.");
		}
		else if(!isMale && !isTall) 
		{
			System.out.println("You are a short and you are not a male.");
		}
		
		isMale = false;
		isTall = true;
		
		if(isMale && isTall) 
		{
			System.out.println("You are a tall male.");
		}
		else if(!isMale && isTall) 
		{
			System.out.println("You are tall but you are not a male");
		}
		else if(isMale && !isTall) 
		{
			System.out.println("You are a short male.");
		}
		else if(!isMale && !isTall) 
		{
			System.out.println("You are a short and you are not a male.");
		}
		
		isMale = true;
		isTall = false;
		
		if(isMale && isTall) 
		{
			System.out.println("You are a tall male.");
		}
		else if(!isMale && isTall) 
		{
			System.out.println("You are tall but you are not a male");
		}
		else if(isMale && !isTall) 
		{
			System.out.println("You are a short male.");
		}
		else if(!isMale && !isTall) 
		{
			System.out.println("You are a short and you are not a male.");
		}
		
		isMale = false;
		isTall = false;
		
		if(isMale && isTall) 
		{
			System.out.println("You are a tall male.");
		}
		else if(!isMale && isTall) 
		{
			System.out.println("You are tall but you are not a male");
		}
		else if(isMale && !isTall) 
		{
			System.out.println("You are a short male.");
		}
		else if(!isMale && !isTall) 
		{
			System.out.println("You are a short and you are not a male.");
		}
		
		System.out.println();
	}
}
