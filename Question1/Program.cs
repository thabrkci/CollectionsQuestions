using System;
using System.Collections;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 positive numbers :)");
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();
            int number = 20;

            // Collect user input for 20 positive numbers
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter the {i + 1}. number:");
                int input;

                // Validate user input to ensure it's a positive number
                while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number!");
                    Console.Write($"Enter the {i + 1}. number:");
                }

                // Check if the entered number is prime
                if (IsPrime(input))
                {
                    primeNumbers.Add(input);
                    Console.WriteLine($"{input} is a prime number.");
                }
                else
                {
                    nonPrimeNumbers.Add(input);
                    Console.WriteLine($"{input} is not a prime number.");
                }
            }

            Console.WriteLine("**********Non-prime Numbers***********");
            int[] nonPrimeArray = (int[])nonPrimeNumbers.ToArray(typeof(int));
            Array.Sort(nonPrimeArray);
            Array.Reverse(nonPrimeArray);

            // Display non-prime numbers in descending order
            foreach (var item in nonPrimeArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********Prime Numbers*********");
            int[] primeArray = (int[])primeNumbers.ToArray(typeof(int));
            Array.Sort(primeArray);
            Array.Reverse(primeArray);

            // Display prime numbers in descending order
            foreach (var item in primeArray)
            {
                Console.WriteLine(item);
            }

            /* ------------------------ */

            // Calculate and display the total number of non-prime and prime numbers
            int totalNonPrimeNumbers = nonPrimeNumbers.Count;
            Console.WriteLine("Total number of non-prime numbers: " + totalNonPrimeNumbers);

            int totalPrimeNumbers = primeNumbers.Count;
            Console.WriteLine("Total number of prime numbers: " + totalPrimeNumbers);

            /* ------------------------ */

            // Calculate and display the average of non-prime and prime numbers
            double averageNonPrimeNumbers = CalculateAverage(nonPrimeNumbers);
            double averagePrimeNumbers = CalculateAverage(primeNumbers);

            Console.WriteLine("Average of non-prime numbers: " + averageNonPrimeNumbers);
            Console.WriteLine("Average of prime numbers: " + averagePrimeNumbers);
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Function to calculate the average of numbers in the ArrayList
        static double CalculateAverage(ArrayList list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += (int)item;
            }
            return (double)sum / list.Count;
        }
    }
}
