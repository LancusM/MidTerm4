using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm4
{
    internal class Program
    {
        public static int CalculateFactorial(int i)
        {
            //sets up returnValue
            //I understand the math that it is doing, with continuing to have the numbers multiply as i grows closer to the input number
            int returnValue = 1;
            for (int n = 1; n <= i; n++)
            {
                returnValue *= n;
            }
            Console.WriteLine(returnValue);
            //writes out returnValue then returns it to the sum calculation
            return returnValue;
        }
        static void Main(string[] args)
        {
            //sets up sum value, prompts user for an integer
            int sum = 0;
            Console.WriteLine("Enter an positive integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 0)
            {
                //ensures input isn't 0 or less, then sets up for loop to continue adding onto the factorial until it reaches the user input
                for (int i = 1; i < input; i++)
                {
                    //CalculateFactorial is called, uses i from for loop. The sum uses the calling of the funtion to sum up the returnValue
                    //sums every loop
                    sum = sum + CalculateFactorial(i);
                    Console.WriteLine("Sum is " + sum);
                }
            }
            else
            {
                Console.WriteLine("You cannot enter a negative number.");
            }
            Console.ReadLine();
        }
    }
}
