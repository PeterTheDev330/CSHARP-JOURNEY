using System;

namespace BankAccountSystem;

class Bank
{
    private readonly List<BankAccount> _accounts = new();

    public BankAccount OpenAccount(string owner, decimal openingBalance = 0)
    {
        var account = new BankAccount(owner, openingBalance);
        _accounts.Add(account);
        return account;
    }

    public BankAccount? Find(int accountNumber) =>
        _accounts.Find(a => a.AccountNumber == accountNumber);
}