using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for the number of rows
            Console.Write("Enter the number of rows: ");
            int numberOfRows = int.Parse(Console.ReadLine());

            // Initialize the current number to be printed
            int currentNumber = 1;

            // Loop through each row
            for (int row = 1; row <= numberOfRows; row++)
            {
                // Loop to print numbers in the current row
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(currentNumber + " "); // Print the current number
                    currentNumber++; // Increment the current number
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}




