using ATMConsoleApp.Domain.Entities;
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

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validate.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Util.GetSecretInput("Enter Your Card Pin"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {

            Console.WriteLine("\nChecking card number and PIN...");
            Util.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Util.PrintMessage("Your Account is Locked! Please go to the nearest Branch to have your Account unlocked.", true);
            Util.PressEnterToContinue();
            Environment.Exit(1);
        }

    }
}
