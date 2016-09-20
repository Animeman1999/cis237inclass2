using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("Input a number to calculate the factorial of:");

            try
            {
                int factroialInt = Convert.ToInt32(Console.ReadLine());

                if (factroialInt < 31)
                {
                    Console.WriteLine(Environment.NewLine + "Problem" + factroialInt + "!");
                    //This call will calculate factorial by using the recursive method
                    int answerInt = Calculate(factroialInt);

                    Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "You must enter a number < 30");
                }
            }
            catch
            {
                Console.WriteLine(Environment.NewLine + "You must enter a number");
            }
        }
        /// <summary>
        /// Calculates the factorial of the number that is passed in
        /// </summary>
        /// <param name="number">Integer</param>
        /// <returns>The Answer</returns>
        public int Calculate(int number)
        {
            if (number == 1)
            {
                return number;
            }
            else
            {
                //This is the recursive call
                return number * Calculate(number - 1);
            }
        }
    }
}
