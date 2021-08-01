using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.OpenClosedPrinciple
{
    //opened for implementation closed for modification
    public abstract class FindArea
    {
        public abstract double Area();
    }
    //Class finds area for square
    public class Square:FindArea
    {
        double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
    }
    //Finds area of a circle
    public class Circle:FindArea
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius; 
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
