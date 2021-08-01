using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.SingleResponsibilityPrinciple
{
    //Bank account onlly gets the bank details
    public class BankAccount
    {
        public long AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }
    }
    //Current account transaction performs only withdrawal and deposit functions
    public class CurrentAccountTransaction
    {
        public BankAccount BalanceAfterWithDraw(BankAccount bankAccount, double Money)
        {
            bankAccount.Balance -= Money;
            return bankAccount;
        }

        public BankAccount BalanceAfterDeposit(BankAccount bankAccount, double Money)
        {
            bankAccount.Balance += Money;
            return bankAccount;
        }
    }
    //This Class gets the money and sends it to transaction,performs the ATM functions
    public class ATM
    {
        public void ATMFunction(BankAccount account)
        {
            Console.WriteLine("Enter the money");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 1 for withdrawal");
            Console.WriteLine("Enter 2 for deposit");
            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    CurrentAccountTransaction withDrawal = new CurrentAccountTransaction();
                    BankAccount mybankAccount = withDrawal.BalanceAfterWithDraw(account, money);
                    Console.WriteLine(mybankAccount.Balance);
                    break;
                case "2":
                    CurrentAccountTransaction deposit = new CurrentAccountTransaction();
                    BankAccount mybankAccount1 = deposit.BalanceAfterDeposit(account, money);
                    Console.WriteLine(mybankAccount1.Balance);
                    break;
            }

        }
    }
}
