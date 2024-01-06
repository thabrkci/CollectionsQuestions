using System;
using System.Collections;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 numbers!");

            // Create ArrayLists to store values.
            ArrayList bigValues = new ArrayList();
            ArrayList smallValues = new ArrayList();

            int[] values = new int[20];

            // Get input from the user for 20 numbers.
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. number:");

                // Validate and store user input.
                while (!int.TryParse(Console.ReadLine(), out values[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Enter the {i + 1}. number:");
                }
            }

            Console.WriteLine("/---------------Entered Numbers-------------------/");
            // Display the entered numbers.
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/--------------------------------------------------/");

            // Sort the array to get the minimum and maximum values.
            Array.Sort(values);

            // Create arrays to store the minimum and maximum three values.
            int[] minThree = new int[3];
            Array.Copy(values, minThree, 3);

            int[] maxThree = new int[3];
            Array.Copy(values, values.Length - 3, maxThree, 0, 3);

            // Calculate averages for the minimum three, maximum three, and overall values.
            double minThreeAverage = CalculateAverage(minThree);
            double maxThreeAverage = CalculateAverage(maxThree);
            double overallAverage = CalculateAverage(values);

            Console.WriteLine("Minimum 3 values:");
            // Display the minimum three values.
            PrintArray(minThree);

            Console.WriteLine("Maximum 3 values:");
            // Display the maximum three values.
            PrintArray(maxThree);

            Console.WriteLine($"Average of the minimum 3 values: {minThreeAverage}");
            Console.WriteLine($"Average of the maximum 3 values: {maxThreeAverage}");
            Console.WriteLine($"Overall average of all values: {overallAverage}");
        }

        // Calculate the average of an array of integers.
        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }

        // Display the elements of an array.
        static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
