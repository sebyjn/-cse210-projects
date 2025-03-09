in this code we will ask the user to Enter number
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Use a while loop to get user input until they enter 0
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            
        
            bool isValid = int.TryParse(userResponse, out userNumber);
            
            if (isValid)
            {
                // Only add the number to the list if it is not 0
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Please enter a valid number.");
            }
        }

        //  proceed with the calculations
        if (numbers.Count > 0)
        {
            // Part 1: Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Part 2: Compute the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the max
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");

            // Part 4: Find the smallest positive number (closest to zero)
            int smallestPositive = int.MaxValue; // Initialize to the largest possible integer
            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("There are no positive numbers.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Part 5: Sort the list
            numbers.Sort();
            Console.WriteLine("Sorted numbers: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            // If no numbers were entered, inform the user
            Console.WriteLine("No numbers were entered.");
        }
    }
}
