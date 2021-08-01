using SolidPriciples.SingleResponsibilityPrinciple;
using System;

namespace SolidPriciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRP
            BankAccount bank = new BankAccount();
            bank.AccountNumber = 55555555555;
            bank.AccountHolderName = "Ram";
            bank.Balance = 5555.28;
            ATM getMoney = new ATM();
            getMoney.ATMFunction(bank);
        }
    }
}
