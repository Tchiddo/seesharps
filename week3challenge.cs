using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_1_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }

        static void GetUserAge()
        {
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();

            try
            {
                int age = int.Parse(ageInput);

                if (age < 0)
                {
                    // Recur
                    Console.WriteLine("Error: Age cannot be negative. Please try again.\n");
                    GetUserAge(); 
                }
                else
                {
                    // If valid no input
                    Console.WriteLine($"You are {age} years old.");
                    
                }
            }
            catch (FormatException)
            {
                // Recur
                Console.WriteLine("Error: Please enter a valid integer.\n");
                GetUserAge(); 
            }
        }
    }
}
