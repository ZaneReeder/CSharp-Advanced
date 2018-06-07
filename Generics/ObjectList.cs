using System;

namespace Generics
{
    //Non generic.
    //Causes issues with performance.
    public class ObjectList
    {
        public void Add(object value)
        {
            //
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
