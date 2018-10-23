using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Controller
    {
        public static int getNumberOfPasses()
        {
            Console.WriteLine("Please enter the number of times you would like to repeat the value entered.");
            string userInput = Console.ReadLine();
            int userNum;
            if (Int32.TryParse(userInput, out userNum))
            {
                return Math.Abs(userNum);
            }
            else
            {
                throw new Exception("Value entered was not a valid number");
            }
        }

        public static char getChar()
        {
            Console.WriteLine("Please enter the single character you would like to repeat.");
            string userInput = Console.ReadLine();
            if (userInput.Length == 1)
            {
                return Convert.ToChar(userInput);
            }
            else
            {
                throw new Exception("Length of input was longer than one character");
            }
        }
    }
}
