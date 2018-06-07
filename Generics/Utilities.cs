using System;

namespace Generics
{



    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()

    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //Constraints
        //Generic Method within nonGeneric Class
        public T Max(T a, T b) //where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
