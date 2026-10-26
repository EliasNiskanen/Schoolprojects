    
namespace ConsoleApp
{
    public class Calculator
    {
        public int? CalculateArea(int? luku1, int? luku2)
        {
            if (luku1*luku2 < 0)
            {
                return(null);
            }
            else
                return(luku1 * luku2);
        }
    }
}