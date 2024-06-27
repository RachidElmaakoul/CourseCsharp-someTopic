namespace OperatorOverLoading.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var M1 = new Money(10);
            var M2 = new Money(20);


            var M3 = M1 + M2;
            var M4 = M1 <= M2;

            Console.WriteLine($" Amount : {M1.Amount}");
            Console.WriteLine($" Amount after Add Methode OverLoading Add two class ({M1.Amount} + {M2.Amount}) : {M3.Amount}");
            Console.WriteLine($"Is Money1 Less Than Money2 ({M1.Amount} <= {M2.Amount}) : {M4}");


            Console.ReadKey();
        }
    }
}
