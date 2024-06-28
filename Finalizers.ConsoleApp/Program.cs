namespace Finalizers.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeSomeGarbage();
            Console.WriteLine($"Memory befor call Gc Collector {GC.GetTotalMemory(false):N0}"); // number is right
            //Console.WriteLine($"Memory befor call Gc Collector {GC.GetTotalMemory(false):N}"); here number is double
            GC.Collect();

            Console.WriteLine($"Memory After call Gc Collector {GC.GetTotalMemory(true):N0}");

            Console.ReadKey();
        }


        static void MakeSomeGarbage()
        {
            Version v;
            
            for (int i = 0; i < 1000; i++)
            {
                v = new Version() ;
            }
        }

    }
}
