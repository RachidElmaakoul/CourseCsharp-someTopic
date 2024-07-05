using System.Drawing;

namespace enumConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Select an Option :[1]Change BackGround Oder [2]Change ForegGround Color ");
            var Option = Console.ReadLine();

            foreach (var Color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.Write($"{Color}\n");
            }
            Console.Write("\n\n Color Is : ");
            var SelectOption = Console.ReadLine();

            ConsoleColor SelectColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), SelectOption,true);

            if (Option == "1")
            {
                Console.BackgroundColor = SelectColor;
            }else if (Option == "2")
            {
                Console.ForegroundColor = SelectColor;

            }else
            {
                Console.WriteLine("Invalid Color ");
            }

            Console.ReadKey();
        
        }

      
    }
}
