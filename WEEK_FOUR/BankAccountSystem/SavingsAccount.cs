using System;
using BankAccountSysem;

namespace BankAccountSystem;

sealed class SavingsAccount : BankAccount, IInterestBearing
{

   public const decimal MinimumBalance = 50m;
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

   public override void Withdraw(decimal amount)
   {
      int numberOfMonths;

      numberOfMonths = ValidateInput("How many months has it been: ", 1, 120);
      if ((numberOfMonths > 6) && (Balance - amount > MinimumBalance))
      {
         base.Withdraw(amount);
         Console.WriteLine("Wtihdraw successful.");
      }
      else
      {
         Console.WriteLine($"Eligibility period not reached (6 months or more) or the savings account must hold at least {MinimumBalance:F2}.");
      }
   }  
}