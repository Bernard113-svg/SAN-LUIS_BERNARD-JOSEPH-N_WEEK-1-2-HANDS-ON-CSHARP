using System;

class Program
{
	static void Main()
	{
		string name = "Bernard"; // Fixed: Added missing semicolon
		int age = 20;
		double pricePerKilo = 20.90;
		char storeName = 'A';
		bool isHighValueFruit = false;

		Console.WriteLine("Hi my name is " + name + ".");
		Console.WriteLine($"Hi my name is {name}.");
		Console.WriteLine($"I am {age} years old."); // Fixed: Capitalized 'L' in WriteLine and removed extra closing parenthesis
		Console.WriteLine($"I bought an apple at store {storeName} for {pricePerKilo} per kilo."); // Fixed: Capitalized 'L' and fixed casing of 'storeName'
		Console.WriteLine($"Is it known for selling high-value fruits? {isHighValueFruit}");
	}
}
