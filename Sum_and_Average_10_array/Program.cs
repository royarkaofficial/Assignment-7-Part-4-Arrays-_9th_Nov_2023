using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_and_Average_10_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays: Sum and Average");
            // Create an array of integers with a minimum size of 5
            int[] randomArray = new int[5];
            Random random = new Random();
            // Populate array with random integers
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }
            // Display array elements
            Console.WriteLine("Array elements:");
            foreach (var element in randomArray)
            {
                Console.Write(element + " ");
            }
            // Calculate and display sum and average
            int sum = 0;
            foreach (var element in randomArray)
            {
                sum += element;
            }
            double average = (double)sum / randomArray.Length;
            Console.WriteLine($"\nSum: {sum}\nAverage: {average}");
        }
    }
}
