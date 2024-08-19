using System.Collections;

namespace Ienumerable_iterator_ex
{
     public class Program
    {
        static void Main(string[] args)
        {
            var ints = new FiveIntegers( 1, 2, 3,4,5 );

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class FiveIntegers : IEnumerable
    {
        private int[] _value;

        public FiveIntegers(int n1,int n2 , int n3, int n4 , int n5)
        {
            _value = new int[] {n1,n2,n3,n4,n5};
        }

         // You can change all these by "yield" KeyWord
       /* public IEnumerator GetEnumerator() => new Enumerator(this);
        class Enumerator : IEnumerator
        {
            int CurrentIndex = -1;
            FiveIntegers _integers;
            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }

            public object Current
            {
                get
                {
                    if (CurrentIndex == -1)
                        throw new InvalidOperationException("Enumeration not started");
                   if (CurrentIndex == _integers._value.Length)
                        throw new InvalidOperationException("Enumeration has ended");

                    return _integers._value[CurrentIndex];
                }
            }

            public bool MoveNext()
            {
                if (CurrentIndex >= _integers._value.Length - 1)
                    return false;

                return ++CurrentIndex < _integers._value.Length;
            }

            public void Reset() => CurrentIndex = -1;
        }*/
        //this is new methode
      public IEnumerator GetEnumerator()
  {
      foreach (var item in _value)
      {
           yield return item;
      }
  } 

    }
}
