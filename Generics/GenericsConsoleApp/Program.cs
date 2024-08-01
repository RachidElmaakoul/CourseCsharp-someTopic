using System.ComponentModel;
using System;
using System.Runtime.Versioning;
namespace GenericsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Numbers = new Any<int>();

            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);

            Numbers.Display();
            Numbers.RemoveItem(1);
            Numbers.Display();

            Console.WriteLine($" IsEmpty:  {Numbers.isEmpty}");
            Console.WriteLine($" Counter:  {Numbers.count}");

            Console.WriteLine("\n______________________________\n");


            var data = new Any<string>();
            data.Add("Hello");
            data.Add("welcome");
            data.Add("to");
            data.Add("Ex");
            data.Display();
            data.RemoveItem(2);
            data.Display();

            Console.WriteLine($" IsEmpty:  {data.isEmpty}");
            Console.WriteLine($" Counter:  {data.count}");


            Console.WriteLine("\n______________________________\n");

            var people = new Any<person>();

            people.Add(new person { FName = "Rachid", LName = "EL Maakoul" });
            people.Display();
            Console.Read();
        }
    }
    public class person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public override string ToString()
        {
            return$"{FName}, {LName}";
        }

    }
    class Any<T>
    {
        private T[] _items;

        public void Add(T item)
        {
           
            if (_items is null)
            {
                _items = new T[] {item };
            }
            else
            {
                var length = _items.Length;
                var dest = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = _items[i];
                }
                dest[dest.Length - 1] = item;
                _items = dest;
            }
        }
         public void RemoveItem(int position)
        {
           
            if (position < 0 || position > _items.Length)
               return;

            else
            {
                var index = 0;
                var dest = new T[_items.Length - 1];
                for (int i = 0; i < _items.Length; i++)
                {
                    if(position == i)
                    continue;

                    dest[index++] = _items[i];

                }
              
                _items = dest;
            }
        }

        public bool isEmpty => _items is null || _items.Length == 0;

        public int count => _items is null ? 0 : _items.Length;


        public void Display()
        {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(_items[i]);
                if( i < _items.Length - 1 )
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
