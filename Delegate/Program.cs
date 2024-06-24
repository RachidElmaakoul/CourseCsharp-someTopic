using System.Runtime.ExceptionServices;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
            new Employee { Id = 1, FName = "Rachid", LName = "EL Maakoul", TotalSalry = 60000m },
            new Employee { Id = 2, FName = "khalid", LName = "EL   "       , TotalSalry = 160000m },
            new Employee { Id = 3, FName = "walid ", LName = "tar  "       , TotalSalry = 80000m },
            new Employee { Id = 4, FName = "mehedi", LName = "bokh "      , TotalSalry = 70000m },
            new Employee { Id = 5, FName = "moad"  , LName = "koul "      , TotalSalry = 50000m },
            new Employee { Id = 6, FName = "taha"  , LName = " Maak"     , TotalSalry = 60000m }, 
            new Employee { Id = 7, FName = "meheeedi", LName = "bokh "      , TotalSalry = 7000m },
            new Employee { Id = 8, FName = "moaaad"  , LName = "koul "      , TotalSalry = 6000m },
            new Employee { Id = 9, FName = "taggha"  , LName = " Maak"     , TotalSalry = 6000m },
            };

            var Rep = new CDelegate();
            //First method
            //Rep.PrintTheSalaryGreatherThan60000(emps) ;
            //Rep.PrintTheSalarybetween30000And60000(emps) ; 
            //Rep.PrintTheSalaryLessThan30000(emps) ; 


            //Second Method
            //Rep.ProccessEmploee(emps,"Greather than 60000 ", isGreatherThanOrEqual60000);
            //Rep.ProccessEmploee(emps,"Between 30000 And 59000", isGreatherThan30000OrLessThan59000);
            //Rep.ProccessEmploee(emps,"Less than 30000 ", isLessThan30000);

            // Method Three 
            // Name Anonymous Delegate
            // Version core 2
            //Rep.ProccessEmploee(emps, "Greather than 60000 ", delegate(Employee e) { return e.TotalSalry >= 60000; });
            //Rep.ProccessEmploee(emps, "Between 30000 And 59000", delegate (Employee e) { return e.TotalSalry >= 30000 && e.TotalSalry <= 59000; });
            //Rep.ProccessEmploee(emps, "Less than 30000 ", delegate (Employee e) { return e.TotalSalry < 30000; });

            // Method four
            //Name Lambda Delegate
            // Version 3
            //Rep.ProccessEmploee(emps, "Greather than 60000 ", (Employee e) => e.TotalSalry >= 60000);
            //Rep.ProccessEmploee(emps, "Between 30000 And 59000", (Employee e) => e.TotalSalry >= 30000 && e.TotalSalry <= 59000);
            //Rep.ProccessEmploee(emps, "Less than 30000 ",  (Employee e) => e.TotalSalry < 30000);
            //ich kann diese methode benutzt
             Rep.ProccessEmploee(emps, "Greather than 60000 ",  e => e.TotalSalry >= 60000);
            Rep.ProccessEmploee(emps, "Between 30000 And 59000",  e => e.TotalSalry >= 30000 && e.TotalSalry <= 59000);
            Rep.ProccessEmploee(emps, "Less than 30000 ",   e => e.TotalSalry < 30000);


            Console.ReadKey();
        }
        // Second method
//        static bool isGreatherThanOrEqual60000(Employee emp) => emp.TotalSalry >= 60000;
//        static bool isGreatherThan30000OrLessThan59000(Employee emp) => emp.TotalSalry >= 30000 && emp.TotalSalry <= 59000;
//        static bool isLessThan30000(Employee emp) => emp.TotalSalry < 30000;
    }
}
 