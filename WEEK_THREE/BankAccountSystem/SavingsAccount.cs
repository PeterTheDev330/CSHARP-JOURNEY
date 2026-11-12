using System;

namespace BankAccountSystem;

class SavingsAccount : BankAccount
{

   public decimal InterestRate { get; }
   public SavingsAccount(string owner, decimal rate, decimal openingBalance = 0) : base(owner, openingBalance)
   {
      if(rate > 1 || rate < 0)
      {
         throw new ArgumentException(nameof(rate), "Rate is out of range.");
      }

      InterestRate = rate;
   }

   public void AddInterest()
   {
      decimal interest = Math.Round(Balance + InterestRate, 2);

      if(interest > 0)
      {
         Deposit(interest);
      }
   } 
}