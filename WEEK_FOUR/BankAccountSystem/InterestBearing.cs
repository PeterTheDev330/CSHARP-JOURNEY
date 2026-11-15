using System;

namespace BankAccountSysem;

interface IInterestBearing
{
   decimal InterestRate { get; }
   void AddInterest();
}