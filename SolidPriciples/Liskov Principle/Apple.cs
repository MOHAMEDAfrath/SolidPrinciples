using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Liskov Principle
namespace SolidPriciples.Liskov_Principle
{
    public abstract class Colour
    {
        public abstract string GetColour();
    }
    public class Apple : Colour
    {
        public override string GetColour()
        {
            return "Red";
        }

    }
    //Derived class is equally substitutable for base class
    public class Orange : Apple
    {
        public override string GetColour()
        {
            return "Orange";

        }

    }
}
