using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.DependencyInversionPrinciple
{
    //High level module
    //Not dependent upon low level module
    public class AutomobileManager
    {
        private IAutoMobile autoMobile;
        public AutomobileManager(IAutoMobile autoMobile)
        {
            this.autoMobile = autoMobile;
        }
        public void Display()
        {
            autoMobile.Wheels();
        }
    }
    public interface IAutoMobile
    {
        void Wheels();
    }
    //Low Level module
    public class Car : IAutoMobile
    {
        public void Wheels()
        {
            Console.WriteLine("Four Wheels");
        }
    }
    public class Bike : IAutoMobile
    {
        public void Wheels()
        {
            Console.WriteLine("Two Wheels");
        }
    }
}
