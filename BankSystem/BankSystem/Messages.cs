using System;

namespace BankSystem;

public class Messages
{
	
	public void GetMainMessages()
	{
        Console.WriteLine("Welcome to the Bank System!");
        Console.WriteLine("1. LogOn (Create Account)");
        Console.WriteLine("2. LogIn (Access Account)");
        Console.WriteLine("3. Exit");
        Console.Write("Please choose an option (1-3): ");
    }

    public void GetAccountMessages() 
    {
        Console.WriteLine("1 - Deposit Money");
        Console.WriteLine("2 - Withdraw Money");
        Console.WriteLine("3 - Exit");
        Console.Write("Please enter a choice: ");
    }
}
