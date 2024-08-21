using System.Security.Cryptography.X509Certificates;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = new List<Tempreture>();
          
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                temps.Add(new Tempreture(rnd.Next(-50, 50)));
            }




            temps.Sort();
            foreach (var item in temps)
            {
                Console.WriteLine(item.Value);
            }


            Console.ReadKey();
        }
    }

    class Tempreture : IComparable
    {
        private int _value;

        public Tempreture(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object obj)
        {

            if (obj is null)
                return 1;

            var temp = obj as Tempreture;

            if (temp is null)
                throw new ArgumentException("Object is Not a Tempreture Object");

            return this._value.CompareTo(temp._value);
        }
    }
}
