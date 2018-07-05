using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long post.";
            var shortenedPost = post.Shorten(5);

            // Usually use extension methods and not create them.
            IEnumerable<int> numbers = new List<int>();
            var max = numbers.Max();

            System.Console.WriteLine(shortenedPost);
        }
    }

}
