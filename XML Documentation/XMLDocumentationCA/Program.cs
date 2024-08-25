

namespace XMLDocumentationCA
{
    public class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Write(" First Name ");
                var FName = Console.ReadLine();

                Console.Write(" Last Name ");
                var LName = Console.ReadLine();

                Console.Write(" Hire Date ");
                DateTime? hireDate = null;
                if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
                {
                    hireDate = hDate;
                }

                var empTd = Generator.GenerateId(FName, LName, hireDate);
                var RandomPassWord = Generator.GenerateRandomPassWord(8);

                Console.WriteLine($"{{\n   ID : {empTd},\n   Firstname : {FName},\n   LastName  : {LName},\n   Hire Date : {hireDate},\n   PassWord  : {RandomPassWord}\n }}");


            } while (1 == 1);

            Console.ReadKey();
        }
    }

    public class Generator 
    {

        public static int LastIdSequenece { get; private set; } = 1;

        public static string GenerateId(string fname , string lname, DateTime? hireDate) 

        {

            if (fname == null)
                throw new InvalidOperationException($"{ nameof(fname)} Can Not be Null ");
              
            if (lname == null)
                throw new InvalidOperationException($"{ nameof(lname)} Can Not be Null ");
              
            if (hireDate == null)
            {
                hireDate = DateTime.Now;
            }else
            {
                if (hireDate.Value.Date < DateTime.Now.Date)
                    throw new InvalidOperationException($"{nameof(fname)} Can Not be in The Past ");
                
            }

            var YearOfHireDate = hireDate.Value.ToString("yy");
            var MonthOfHireDate = hireDate.Value.ToString("MM");
            var DayOfHireDate = hireDate.Value.ToString("dd");

            var Code = $"{fname.ToLower()[0]}{lname.ToLower()[0]} {YearOfHireDate} {MonthOfHireDate} {DayOfHireDate} {(LastIdSequenece++).ToString().PadLeft(2,'0')}";

            return Code;

        
        }

        public static string GenerateRandomPassWord(int length) 
        {

            const string ValidScope = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz";
                var Result = "";

            var rand = new Random();
            while(0 < length--)
            {
                Result += (ValidScope[rand.Next(ValidScope.Length)]);
            }


            return Result;
        }


    }
}
