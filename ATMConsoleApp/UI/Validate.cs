using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp.UI
{
    public static class Validate
    {
        // validates input and returns either the prompt and card number or error message
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {

                userInput = Util.GetUserInput(prompt);


                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));

                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }

                }
                catch
                {                  
                    Util.PrintMessage("Invalid Input, Please Try Again!", false);
                }
            }
            return default;
        }
    }
}
