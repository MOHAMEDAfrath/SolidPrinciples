using SolidPriciples.DependencyInversionPrinciple;
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
            Console.WriteLine("*******Single responsibility Principle*******");
            BankAccount bank = new BankAccount();
            bank.AccountNumber = 55555555555;
            bank.AccountHolderName = "Ram";
            bank.Balance = 5555.28;
            ATM getMoney = new ATM();
            getMoney.ATMFunction(bank);

            //OCP
            Console.WriteLine("*******Open closed Principle*******");
            FindArea findArea = new Square(5.55);
            FindArea find = new Circle(5.98);
            Console.WriteLine(findArea.Area());
            Console.WriteLine(find.Area());

            //LSP
            Console.WriteLine("*******Liskov Principle*******");
            Colour apple = new Apple();
            Colour orange = new Orange();
            Console.WriteLine("The colour of orange is " + orange.GetColour());
            Console.WriteLine("The colour of apple is " + apple.GetColour());
            //ISP
            Console.WriteLine("*******Interface segregation Principle*******");
            Console.WriteLine("Online Order");
            IOnlineOrder onlineOrder = new OnlineOrder();
            onlineOrder.Order();
            onlineOrder.OnlinePayment();
            Console.WriteLine("Offline order");
            IOfflineOrder offlineOrder = new PayOnDelivery();
            offlineOrder.Order();
            //DIP where high level module depends on abstraction not on low level modules
            Console.WriteLine("*******Dependency Inversion Principle*******");
            IAutoMobile car = new Car();
            AutomobileManager automobilemanager = new AutomobileManager(car);
            automobilemanager.Display();
            IAutoMobile bike = new Bike();
            AutomobileManager automobilemanager1 = new AutomobileManager(bike);
            automobilemanager1.Display();



        }
    }
}
