using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    /// <summary>
    /// Object that knows how to call a method
    /// Pointer/Reference to a function
    /// Designing extensible and flexible applications like a framework
    /// Interfaces can also be used in this context.
    /// Use Delegate when eventing design pattern or
    /// when caller doesnt need to access other properties or methods.
    /// </summary>

    class Program
    {

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Applied Remove Red Eye");
        }

        static void Main(string[] args)
        {

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("photo.jpg", filterHandler);

        }
    }
}
