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

            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validate.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Util.GetSecretInput("Enter Your Card Pin"));
        }

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>();
            {
                userAccountList = new List<UserAccount>
                {
                    new UserAccount { Id = 1, FullName = "Mike", AccountNumber = 123456, CardNumber = 321321, CardPin = 123123, AccountBalance = 10000.00, IsLocked = false, },
                    new UserAccount { Id = 1, FullName = "Keith", AccountNumber = 654321, CardNumber = 123123, CardPin = 321321, AccountBalance = 10000.00, IsLocked = false, },
                    new UserAccount { Id = 1, FullName = "Joe", AccountNumber = 111111, CardNumber = 222222, CardPin = 333333, AccountBalance = 10000.00, IsLocked = false, },
                };
        }
            

        }
    } 
}