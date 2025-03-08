using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
// In this code, we will ask the user for first and last name

      Console.Write("what is your first name ?");
      string first = Console.ReadLine();

      Console.Write("what is your last name? ");
      string last = Console.ReadLine();
Console.WriteLine($"your name is: {last},{first},{last}");




    }
}