using System;
using System.Text.RegularExpressions;

namespace BankSystem
{
    public class BankAccount
    {
        private string _accountName;
        private string _password;

        public string AccountName
        {
            get => _accountName;
            set
            {
                if (value.Length < 8)
                {
                    Console.WriteLine("Account name cannot be shorter than 8 characters");
                }
                else
                {
                    _accountName = value;
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password form is incorrect");
                }
            }
        }

        public BankAccount(string accountName, string password)
        {
            AccountName = accountName;
            Password = password;
        }
        public bool Login(string accountName, string password)
        {
            return this._accountName == accountName && this._password == password;
        }
        
        public string LoginMessage(string accountName, string password)
        {
            if (Login(accountName, password))
            {
                return "You are logged in.";
            }
            else
            {
                return "You are not logged in. Please try again.";
            }
        }
    }
}
