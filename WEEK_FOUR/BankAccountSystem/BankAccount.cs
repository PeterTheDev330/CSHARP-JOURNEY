using System;

namespace BankAccountSystem;

class BankAccount
{
    private static int _nextNumber = 1000;

    public int AccountNumber { get; }
    public string Owner { get; }
    public decimal Balance { get; protected set; }

    private readonly List<BankAccount> _accounts = new();
    private readonly List<Transaction> _transactions = new();
    public IReadOnlyList<Transaction> Transactions => _transactions;

    public BankAccount(string owner, decimal openingBalance = 0)
    {
        if (string.IsNullOrWhiteSpace(owner))
        {
            throw new ArgumentException("Owner name can't be empty.", nameof(owner));
        }
        if(openingBalance < 0)
        {
            throw new ArgumentException(nameof(openingBalance), "Opening balance can't be negative.");
        }

        AccountNumber = _nextNumber++;
        Owner = owner.Trim();
        Balance = openingBalance;
    }

    //public BankAccount? Find(int accountNumber) =>
    //    _accounts.Find(a = a.AccountNumber == accountNumber);

    // the input validation function came here
    public int ValidateInput(string prompt, double lower, double upper)
    {

        int input;

        Console.Write(prompt);

        while (!int.TryParse(Console.ReadLine(), out input) || input < lower || input > upper)
        {
            Console.WriteLine($"Enter a number between {lower} and {upper}");
            Console.Write("Try Again: ");
        }

        return input;
    }

    public void Deposit(decimal amount)
    {

        if(amount <= 0)
        {
            throw new ArgumentException(nameof(amount), "Deposit amount must be above zero.");
        }

        Balance += amount;
        _transactions.Add(new Transaction(TransactionType.Deposit, amount, Balance));
    }

    public virtual void Withdraw(decimal amount)
    {

        if(amount < 0)
        {
            throw new ArgumentException(nameof(amount), "Withdraw amount can't be negative.");
        }
        if(amount > Balance)
        {
            throw new ArgumentException(nameof(amount), "Insufficient funds.");
        }

        Balance -= amount;
        _transactions.Add(new Transaction(TransactionType.Withdrawal, amount, Balance));

    }

    public override string ToString() => $"# {AccountNumber} {Owner}: {Balance:C}";
}