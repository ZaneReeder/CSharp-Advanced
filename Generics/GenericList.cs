using System;

namespace Generics
{

    //T is Parameter. Multiple Parameters are possible.
    public class GenericList<T> 
    {
        public void Add(T value)
        {
            //
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
