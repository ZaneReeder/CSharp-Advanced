using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


    class Program
    {
        static void Main(string[] args)
        {

            //var book = new Book { Isbn = "0001", Title = "C# Advanced" };

            ////var numbers = new List();
            ////numbers.Add(10);

            ////var books = new BookList();
            ////books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(book);

            //// At runtime there is no casting or boxing because
            //// the generic type allows lists to be of given type.

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", book);


            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has value?" + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOfDefault());


        }
    }
}
