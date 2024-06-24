using System;


namespace Delegate
{
   public class CDelegate
    {

        //first method
        //   public void PrintTheSalaryGreatherThan60000(Employee[] employyes)
        //    {
        //        Console.WriteLine("\nThe Salary That Greather than $60000* ");
        //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //        foreach (Employee e in employyes)
        //        {
        //            if (e.TotalSalry > 60000m)
        //                Console.WriteLine($"{e.Id} | {e.FName} {e.LName} | {e.TotalSalry}");

        //        }
        //    }  
        //    public void PrintTheSalarybetween30000And60000(Employee[] employyes)
        //    {
        //        Console.WriteLine("\nThe Salary That between $30000 And $60000 ");
        //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //        foreach (Employee e in employyes)
        //        {
        //            if (e.TotalSalry >= 30000m && e.TotalSalry <= 60000m)
        //                Console.WriteLine($"{e.Id} | {e.FName} {e.LName} | {e.TotalSalry}");

        //        }
        //    } 
        //    public void PrintTheSalaryLessThan30000(Employee[] employyes)
        //    {
        //        Console.WriteLine("\nThe Salary That Less than $30000* ");
        //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //        foreach (Employee e in employyes)
        //        {
        //            if (e.TotalSalry <= 30000m)
        //                Console.WriteLine($"{e.Id} | {e.FName} {e.LName} | {e.TotalSalry}");

        //        }
        //    }

        public delegate bool ElligableSalse(Employee e);
        public void ProccessEmploee(Employee[] employyes, string titel, ElligableSalse isElligable)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(titel);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (Employee e in employyes)
            {
                if (isElligable(e))
                    Console.WriteLine($"{e.Id} | {e.FName} {e.LName} | {e.TotalSalry}");

            }
            Console.WriteLine("\n\n");
        }

    }
}
