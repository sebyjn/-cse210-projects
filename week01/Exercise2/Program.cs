// In this code,I will be using percentage of each grade and display each letter match to them

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Ask the user to input their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());  // Convert input to integer

        // Variable to store the letter grade
        string letter = "";

        // Determine the letter grade and display corresponding messages
        if (gradePercentage > 90)
        {
            Console.WriteLine("Wow! You outdo the level!");
            letter = "A";
        }
        else if (gradePercentage > 80)
        {
            Console.WriteLine("Congrats, well done!");
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("You reached 70, keep it up!");
            letter = "C";
        }
        else
        {
            Console.WriteLine("DAMN, you lost. Don't give up, try again next time!");
            letter = "F";
        }

        // Output the final letter grade
        Console.WriteLine("Your letter grade is: " + letter);

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and try again next time.");
        }
    }
}

