using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp.UI
{
     public static class AppScreen
    {
        internal static void Welcome()
        {
            // clears the console screen
            Console.Clear();
            // set the title of the console window
            Console.Title = "Simple ATM App";
            // sets the text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //set the welcome message
            Console.WriteLine("\n\n                                      ----------Welcome to Simple ATM----------\n");
            Console.WriteLine("                                      *                                       *");
            Console.WriteLine("                                      *                                       *");
            Console.WriteLine("                                      *                                       *");
            Console.WriteLine("                                      -----------------------------------------");
            Util.PressEnterToContinue();
        }

        
    }
}
