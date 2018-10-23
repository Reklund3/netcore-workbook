using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            try
            {
                model.userInput = Controller.getChar();
                model.numberOfPasses = Controller.getNumberOfPasses();
                View.repeatChar(model);
            }
            catch
            {
                Console.WriteLine("An error was encountered please try again.");
            }
            Console.ReadLine();
        }

        
    }
}
