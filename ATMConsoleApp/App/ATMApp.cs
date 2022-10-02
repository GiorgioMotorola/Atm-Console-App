using ATMConsoleApp.Domain.Entities;
using ATMConsoleApp.Domain.Interfaces;
using ATMConsoleApp.UI;
using System.Collections.Generic;

namespace ATMConsoleApp.App
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void CheckUserCardNumberAndPassword()
        {
            bool isCorrectLogin = false;
            while(isCorrectLogin == false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();
                AppScreen.LoginProgress();
                foreach(UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if(inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;

                            if (selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                }

            }
            if(isCorrectLogin == false)
            {
                Util.PrintMessage("\nInvalid Card Number or PIN!", false);
                selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                if(selectedAccount.IsLocked)
                {
                    AppScreen.PrintLockScreen();
                }
            }
            Console.Clear();
            
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome Back, {selectedAccount.FullName}");
        }

            // adds user accounts
            public void InitializeData()
        {
            userAccountList = new List<UserAccount>();
            {
                userAccountList = new List<UserAccount>
                {
                    new UserAccount { Id = 1, FullName = "Mike", AccountNumber = 123456, CardNumber = 123123, CardPin = 123123, AccountBalance = 10000.00, IsLocked = false, },
                    new UserAccount { Id = 1, FullName = "Keith", AccountNumber = 654321, CardNumber = 123123, CardPin = 321321, AccountBalance = 10000.00, IsLocked = false, },
                    new UserAccount { Id = 1, FullName = "Joe", AccountNumber = 111111, CardNumber = 222222, CardPin = 333333, AccountBalance = 10000.00, IsLocked = false, },
                };
        }
            

        }
    } 
}