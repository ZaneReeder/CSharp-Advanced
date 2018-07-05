using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        /// <summary>
        /// Statically-Typed vs Dyanimcally-Typed
        /// Type resolution at compile time vs run time
        /// .NET 4 added the dynamic capability
        /// </summary>
        static void Main(string[] args)
        {
            //object obj = "Zane";
            ////obj.GetHashCode();

            ////reflection
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //dynamic excelObject = "name2";
            //excelObject.Optimize();

            dynamic name = "Zane";
            name = 10;

            dynamic a = 10;
            dynamic b = 20;

            // c becomes dynamic. dynamic expressions are also dynamic
            var c = a + b;

            int i = 5;
            dynamic d = i; //dynamic integer
        }


    }
}
