using System;

namespace ShapesLibrary
{
    public class Circle:IShape
    {
        public override string ToString()
        {
            return("Circle with radius "+radius.ToString("#.00")+" has area "+Area().ToString("#.00")+" and circumference "+Circumference().ToString("#.00")).Replace(",",".");
        }
        private double radius {get; set;}

        public double Area()
        {
            return(Math.PI * (this.radius * this.radius));
        }
        public double Circumference()
        {
            return((2 * Math.PI) * this.radius);
        }
        public Circle(double radius)
        {
            this.radius = radius;

        }
        public Circle()
        {

        }
    }
}