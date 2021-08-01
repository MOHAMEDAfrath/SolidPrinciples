using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.InterfaceSegregationPrinciple
{
    //Interface segregated 
    public interface IOnlineOrder
    {
        public void Order();
        public void OnlinePayment();
    }
    public interface IOfflineOrder
    {
        public void Order();
    }
    //Payed through online separate interface
    public class OnlineOrder : IOnlineOrder
    {
        public void Order()
        {
            Console.WriteLine("Ordered");

        }
        public void OnlinePayment()
        {
            Console.WriteLine("Payed Online");
        }

    }
    //No payment done through online so separate interface 
    public class PayOnDelivery : IOfflineOrder
    {
        public void Order()
        {
            Console.WriteLine("Ordered! Pay on Delivery!");

        }
    }
        
}
