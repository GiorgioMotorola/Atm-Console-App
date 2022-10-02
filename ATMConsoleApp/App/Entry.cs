using ATMConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp.App
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            // calls Welcome class
            AppScreen.Welcome();
           
            ATMApp atmApp = new ATMApp();

            atmApp.CheckUserCardNumberAndPassword();

            Util.PressEnterToContinue();
        }
    }
}
