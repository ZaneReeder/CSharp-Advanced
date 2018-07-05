using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        /// <summary>
        /// Value Types cannot be null.
        /// But this is often desired, and
        /// in these cases we use nullable types.
        /// </summary>
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2014, 1, 1);

            //Console.WriteLine("GetValueOrDefault() : " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue : " + date.HasValue);
            //Console.WriteLine("Value : " + date.Value); //must have value

            DateTime date2 = date.GetValueOrDefault();

            //Value => Nullable no problemss
            DateTime? date3 = date2;

            //Null Coalescing Operator
            DateTime? date4 = null;
            DateTime date5 = date4 ?? DateTime.Today; //equivalent to below

            //if (date4 != null)
            //    date5 = date.GetValueOrDefault();
            //else
            //    date5 = DateTime.Today;


        }
    }
}
