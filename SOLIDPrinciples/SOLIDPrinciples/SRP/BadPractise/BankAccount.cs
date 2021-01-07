using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.SRP.BadPractise
{
    public abstract class BankAccount
     {
     double Balance { get; }
     void Deposit(double amount) { }
     void Withdraw(double amount) { }
     void AddInterest(double amount) { }
     void Transfer(double amount, IBankAccount toAccount) { }
     }
}
