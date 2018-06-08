using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    /// <summary>
    /// Lamda Expressions is an anonymous method.
    ///     No access mod. No name. No return statement.
    /// Why?
    ///     convenience.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

            //args => expression
            //number1 => number1 * number1;

            // () => ...
            // x => ...
            // (x,y,z) =>

            // <argument, returned data type>
            //Func<int, int> square = num => num * num
            //Console.WriteLine(square(5));

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //var result = multiplier(10);
            //Console.WriteLine(result);


            //// Without Lamda
            //var books = new BookRepo().GetBooks();
            //var cheaperBooks = books.FindAll(IsCheaperThan16Dollars);

            //foreach(var book in cheaperBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //With
            var books = new BookRepo().GetBooks();
            var cheaperBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
