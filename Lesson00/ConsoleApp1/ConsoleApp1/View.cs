using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class View
    {
        public static void repeatChar(Model model)
        {
            for (int i = 0; i < model.numberOfPasses; i++)
            {
                Console.Write(model.userInput);
            }
        }
    }
}
