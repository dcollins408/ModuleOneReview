using System;

namespace ModuleOneReview
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Hello friend. We are going to finish up Module One with some math. First, we have the circle method."); // Setting up the call to the circle method
			Console.WriteLine("What is the radius of your circle?"); // asking the user for the radius of the circle
			var radius = Console.ReadLine(); // read in the radius
			double convertedRadius = Convert.ToDouble(radius); // convert the string we got above into a double

			Circle(convertedRadius); // Calling the method to calculate the circle

			Console.WriteLine("What is the height of your triangle?"); // Requesting the height of the triangle
			var height = Console.ReadLine(); // read in the height of the triangle
			double convertedHeight = Convert.ToDouble(height); // convert the height to a double

			Console.WriteLine("Thank you. What is the length of the base of your triangle?"); // Requesting teh base of the triangle
			var baseValue = Console.ReadLine(); // read in the value of the base
			double convertedBase = Convert.ToDouble(baseValue); // cast the string into a double

			Triangle(convertedBase, convertedHeight); // calling the Triangle method with the converted base and height numbers

			Console.WriteLine("What is the width of your rectangle?"); // Requesting the width of the rectangle
			var width = Console.ReadLine(); // read in the value of the width
			double convertedWidth = Convert.ToDouble(width); // cast the string into a double

			Console.WriteLine("What is the length of your rectangle?"); // Request length of the rectangle
			var length = Console.ReadLine(); // read in the value of the length
			double convertedLength = Convert.ToDouble(length); // cast the string into a double

			Rectangle(convertedWidth, convertedLength); // call the Rectangle method

			Console.WriteLine("Last calculation. What is the length of one side of your square?"); // requesting the length of the area of one side of the square
			var side = Console.ReadLine(); // read in the value of the side
			double convertedSide = Convert.ToDouble(side); // cast the string into a double

			Square(convertedSide); // call the Square method

			Console.WriteLine("That's it. Hopefully that was what the assignment requested! Also, am I over-commenting the code? Or is it better to do that to make it more readable in the future?"); // Final output to finish the program



		}

		


	

	public static void Circle(double convertedRadius) //This is the circle method
	{
	
		double rsquared = convertedRadius * convertedRadius; // the area of a circle is pi times r squared, so we need to get r squared
		double output = (3.14159 * rsquared); // put the area in a variable called output 
		Console.WriteLine($"The area of your circle is: {output}"); // Giving output to the user to let them know the area of the circle
	}

	public static void Triangle(double convertedBase, double convertedHeight) // This is the triangle method
	{
	
		double initial = convertedBase * convertedHeight; // since the forumla is one half base time height, I wanted to avoid issue with order of operations and do the second part first
		double output = (.5 * initial); // put the value of the area in a variable
		Console.WriteLine($"The area of your triangle is: {output}"); // Give output to the user about the area of the circle

	}

	public static void Rectangle(double convertedWidth, double convertedLength) // This is the rectangle method
	{

		double output = (convertedWidth * convertedLength); // put the area in a variable
		Console.WriteLine($"The area of your rectangle is: {output}"); // Give output to the user
	}

	public static void Square(double convertedSide) // This is the square method
	{

		double output = (convertedSide * convertedSide); // put the area in a variable
		Console.WriteLine($"The area of your square is: {output}"); // Giving output to the user to let them know that what will follow is the area of their square
		
	}
	
	}

}










