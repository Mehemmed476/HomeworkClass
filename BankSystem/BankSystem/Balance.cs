namespace BankSystem;

public class Balance : BankAccount
{
    private decimal _currentBalance;

    public decimal CurrentBalance
    {
        get
        {
            return _currentBalance;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: Current balance cannot be negative");
            }
            else
            {
                _currentBalance = value;
            }
        }
    }

    public Balance(string accountName, string password, decimal currentBalance) : base(accountName, password)
    {
        AccountName = accountName;
        CurrentBalance = currentBalance;
        Password = password;
    }

    public void AddMoney(decimal amount)
    {
        _currentBalance += amount;
    }

    public void WithdrawMoney(decimal amount)
    {
        if (amount > _currentBalance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            _currentBalance -= amount;
        }
    }
}