using System;
using System.Globalization;
using System.Numerics;
namespace GenericDelegetType
{
    public delegate bool Filter<in T> (T value);
    internal class Program
    {
        static void Main(string[] args)
        {
           IEnumerable<int> List1 = new int[] { 1,2,3,9,4,6,7,13,10,7,5,14,16,19};
            Console.WriteLine("Numbers Less Than six : ");
            printNumbers(List1, n => n <= 6); 
            
            Console.WriteLine("Numbers bitween 10 and 20 : ");
            printNumbers(List1, n =>  n >= 10 && n <= 20);
            
            Console.WriteLine("Even Numbers : ");
            printNumbers(List1, n =>  n % 2 == 0);

            Console.WriteLine("Odd Numbers : ");
            printNumbers(List1, n =>  n % 2 != 0);

            IEnumerable<decimal> List2 = new decimal[] { 1.33m, 2.762m, 30.3m,2.02m, 9.1m,  14.001m, 0.16m, 19.332m };
            Console.WriteLine("Numbers greather Than 2.01 : ");
            printNumbers(List2, n => n > 2.01m);


            Console.Read();
        }

        static  void printNumbers<T>(IEnumerable<T> numbers, Filter<T> filter)
        {
            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
