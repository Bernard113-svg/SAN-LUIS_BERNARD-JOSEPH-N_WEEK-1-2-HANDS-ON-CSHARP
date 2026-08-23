using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("How old are you? ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much money do you have (e.g. 19.99)? ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("What letter grade did you get in school (e.g. A)? ");
        char grade = Convert.ToChar(Console.ReadLine());

        Console.Write("Are you a student? (true/false) ");
        bool isStudent = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"My name is {name}, I am {age} years old, I have ${price} in my pocket, I got a {grade} in school, and it is {isStudent} that I am currently a student.");
    }
}