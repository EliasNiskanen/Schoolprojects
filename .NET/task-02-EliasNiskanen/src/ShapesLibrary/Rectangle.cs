using System;

namespace ShapesLibrary
{
    public class Rectangle:IShape
    {
        public override string ToString()
        {
            return("Rectangle with width "+width.ToString("#.00")+" and height "+height.ToString("#.00")+" has area "+Area().ToString("#.00")+" and circumference "+Circumference().ToString("#.00")).Replace(",",".");
        }
        private double width {get; set;}

        private double height {get; set;}

        public double Area()
        {
            return(this.height*this.width);
        }
        public double Circumference()
        {
            return(2*(this.width+this.height));
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle()
        {

        }

    }
}