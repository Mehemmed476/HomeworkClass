using System;
using System.Threading;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null; 
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bank System!");
                Console.WriteLine("1. LogOn (Create Account)");
                Console.WriteLine("2. LogIn (Access Account)");
                Console.WriteLine("3. Exit");
                Console.Write("Please choose an option (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        
                        Console.Write("Account Name (min 8 characters): ");
                        string accountName = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        
                        account = new BankAccount(accountName, password);
                        Console.WriteLine("Account created. Please Log In.");
                        Thread.Sleep(2000);
                        break;

                    case "2": 
                        if (account == null)
                        {
                            Console.WriteLine("You must create an account first!");
                            Thread.Sleep(2000);
                            continue; 
                        }

                        Console.Write("Account Name: ");
                        string loginAccountName = Console.ReadLine();
                        Console.Write("Password: ");
                        string loginPassword = Console.ReadLine();

                        if (account.Login(loginAccountName, loginPassword))
                        {
                            Console.WriteLine(account.LoginMessage(loginAccountName, loginPassword));
                            Thread.Sleep(2000);
                            
                            Console.Clear();
                            Console.WriteLine("Account Balance: ");
                            decimal currentBalance;
                            Console.Write("Enter your current balance: ");
                            while (!decimal.TryParse(Console.ReadLine(), out currentBalance))
                            {
                                Console.WriteLine("Please enter a valid decimal number.");
                            }
                            
                            Balance newBalance = new Balance(account.AccountName, account.Password, currentBalance);
                            bool accountRunning = true;
                            while (accountRunning)
                            {
                                Console.Clear();
                                Console.WriteLine($"User: {newBalance.AccountName}");
                                Console.WriteLine($"Current Balance: {newBalance.CurrentBalance}\n\n\n");
                                Console.WriteLine("1 - Deposit Money");
                                Console.WriteLine("2 - Withdraw Money");
                                Console.WriteLine("3 - Exit");
                                Console.Write("Please enter a choice: ");
                                choice = Console.ReadLine();
                                decimal Money;
                            
                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("Enter amount of money: ");
                                        Money= decimal.Parse(Console.ReadLine());
                                        newBalance.AddMoney(Money);
                                        Console.WriteLine($"Money added to current balance.");
                                        Thread.Sleep(2000);
                                        break;
                                    
                                    case "2":
                                        Console.WriteLine("Enter amount of money: ");
                                        Money = decimal.Parse(Console.ReadLine());
                                        newBalance.WithdrawMoney(Money);
                                        Console.WriteLine("Money withdrawn from current balance.");
                                        Thread.Sleep(2000);
                                        break;
                                    
                                    case "3":
                                        accountRunning = false;
                                        Console.WriteLine("You exit your account. Goodbye!");
                                        Thread.Sleep(2000);
                                        break; 
                                    
                                    default:
                                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                                        Thread.Sleep(2000);
                                        break;
                                } 
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Login failed! Please check your credentials.");
                            Thread.Sleep(2000);
                        }
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Thank you for using the Bank System. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
