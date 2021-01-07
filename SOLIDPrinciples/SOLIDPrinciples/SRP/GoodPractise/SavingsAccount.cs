using SOLIDPrinciples.SRP.BadPractise;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.SRP.GoodPractise
{
    public class SavingsAccount : BankAccount
    {
        public void AddInterest(double amount) { }
    }
}
