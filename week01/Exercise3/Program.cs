// in this code we will ask users which will aks for number
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // We are going to add a random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Generate a number between 1 and 100

        int guess = -1;

        // Ask the user for a guess until they get it right
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); // Read and convert the user input to an integer

            // Provide feedback if the guess is lower or higher than the magic number
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the right number.");

                boolean PlayAgain = false;
            }
        }
    }
}
