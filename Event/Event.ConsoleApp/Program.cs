using System.Runtime.CompilerServices;

namespace Event.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stock = new Stock("Amazon");

            stock.Price = 100;

            stock.OnPriceChanged += (Stock stock, decimal oldPrice) => {
 string Result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Result = "UP";
            }else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Result = "Down";

            }
            else {
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine($" {stock.Name}  : {stock.Price} - {Result}");

                
            };

            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0.0m);

            Console.ReadKey();
        }

      /*  private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            string Result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Result = "UP";
            }else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Result = "Down";

            }
            else {
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine($" {stock.Name}  : {stock.Price} - {Result}");
        } */
    }
}
