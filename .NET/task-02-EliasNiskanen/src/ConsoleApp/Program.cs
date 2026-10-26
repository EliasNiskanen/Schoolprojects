using ShapesLibrary;

namespace ConsoleApp
{ 
    class program
    { 
        static void Main(string[] args)
        { 
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(4.00, 5.00);
                Console.WriteLine(circle);
                Console.WriteLine(rectangle);
        }
    }
}
