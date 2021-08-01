using SolidPriciples.InterfaceSegregationPrinciple;
using SolidPriciples.Liskov_Principle;
using SolidPriciples.OpenClosedPrinciple;
using SolidPriciples.SingleResponsibilityPrinciple;
using System;

namespace SolidPriciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRP
            //BankAccount bank = new BankAccount();
            //bank.AccountNumber = 55555555555;
            //bank.AccountHolderName = "Ram";
            //bank.Balance = 5555.28;
            //ATM getMoney = new ATM();
            //getMoney.ATMFunction(bank);

            //OCP
            //FindArea findArea = new Square(5.55);
            //FindArea find = new Circle(5.98);
            //Console.WriteLine(findArea.Area());
            //Console.WriteLine(find.Area());

            //LSP
            //Colour apple = new Apple();
            //Colour orange = new Orange();
            //Console.WriteLine("The colour of orange is " +orange.GetColour());
            //Console.WriteLine("The colour of apple is " + apple.GetColour());
            //ISP
            Console.WriteLine("Online Order");
            IOnlineOrder onlineOrder = new OnlineOrder();
            onlineOrder.Order();
            onlineOrder.OnlinePayment();
            Console.WriteLine("Offline order");
            IOfflineOrder offlineOrder = new PayOnDelivery();
            offlineOrder.Order();
            
        }
    }
}
