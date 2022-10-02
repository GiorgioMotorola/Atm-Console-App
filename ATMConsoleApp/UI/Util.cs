using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp.UI
{
    public static class Util
    {
        public static void PressEnterToContinue()
        {
            // allows user to continue by pressing Enter
            Console.WriteLine("\n\nPress Enter to Continue...\n");
            Console.ReadLine();
        }

        public static void PrintDotAnimation(int timer = 10)
        {
            
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
                
            }
            Console.Clear();
        }

        public static string GetUserInput(string prompt)
        {
            // enables us to reuse "Enter" thru the program
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        // changes color to red if input is false
        public static void PrintMessage(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Yellow;
            PressEnterToContinue();
        }

        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string asterics = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                isPrompt = false;

                ConsoleKeyInfo inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if (input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMessage("\nPlease Enter 6 Digits.", false);
                        input.Clear();
                        isPrompt = true;
                        continue;
                    }

                }
                if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                }
                else if (inputKey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputKey.KeyChar);
                    Console.Write(asterics + "*");
                }
        

       }
            return input.ToString();

        }
    }
}
