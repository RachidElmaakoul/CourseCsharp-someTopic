using System.Reflection.Metadata.Ecma335;

namespace Exception_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                badMethod();
            }

            //catch specific Exceotion
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("sorry can not  divide by zero");
            }

            // Catch Multiple Exception 
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Argument Null Excepting");
            }
            catch (AggregateException ex) 
            {

                Console.WriteLine("Argument  Excepting");

            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine("Argument out of Range  Excepting");

            }

            // catch Exception Filter
            catch (Exception ex) when (ex.Source == "Exception_CA") 
            {
            Console.WriteLine("Exception Filter");
            }
            


            Console.Read();
        }
        static int badMethod()
        {
            int x = 2;
            int y = 0;
            return x / y;
        }
    }
}
