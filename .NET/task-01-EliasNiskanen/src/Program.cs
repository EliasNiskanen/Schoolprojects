using ConsoleApp;

// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {   
        int? luku1 = 2;
        int? luku2 = null;

        Console.WriteLine("Hello, .NET!");

        if (args.Length ==2 ){
               try
                {
                    luku1 = int.Parse(args[0]);
                }
                catch (InvalidCastException e)
                {
                    luku1 = null;
                }
                try
                {
                    luku2 = int.Parse(args[1]);
                }
                catch (InvalidCastException e)
                {
                    luku2 = 0;
                }
        }
            else if (args.Length ==2){
                luku1 = int.Parse(args[0]);
                luku2 = int.Parse(args[1]);
        }
        Console.WriteLine("Arguments: {0} {1}",luku1,luku2);
        Calculator calculator = new Calculator();
        int? laskin = calculator.CalculateArea(luku1, luku2);
        if(luku1 == null)
            luku1 = 0;
        if(luku2 == null)
            luku2= 0;
        if (laskin == null)
            laskin =0;
            Console.WriteLine("Area of "+luku1+" and "+luku2+" is "+laskin);
    }
}