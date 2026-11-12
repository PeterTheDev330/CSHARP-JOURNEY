using System;

using BankAccountSystem;

enum TransactionType
{
    Deposit, 
    Withdrawal
}

class Transaction
{
    public DateTime Date { get; }
    public TransactionType Type { get; }
    public decimal Amount { get; }
    public decimal BalanceAfter { get; }

    public Transaction(TransactionType type, decimal amount, decimal balanceAfter)
    {
        Date = DateTime.Now;
        Type = type;
        Amount = amount;
        BalanceAfter = balanceAfter;
    }


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

    public override string ToString() => $"{Date:yyyy-MM-dd HH:mm} | {Type,-10} | {Amount,10:F2} | {BalanceAfter,10:F2}";

}