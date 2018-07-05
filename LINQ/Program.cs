using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title1", Price = 7.80f },
                new Book() {Title = "Title2", Price = 14.95f },
                new Book() {Title = "Title3", Price = 4.53f },
                new Book() {Title = "Title4", Price = 2.50f },
                new Book() {Title = "Title5", Price = 9.99f },
            };
        }
    }

    class Program
    {
        /// <summary>
        ///  Language Integrated Query
        ///  Gives the capabilities to query objects.
        ///  Query:
        ///     objects in memory
        ///     Databases (LINQ to Entities)
        ///     XML
        ///     ADO.NET data sets
        /// </summary>

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            ////LINQ QUERY OPERATORS
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title;

            ////LINQ EXTENSION METHODS
            //var cheapBooks = books
            //        .Where(b => b.Price < 10)
            //        .OrderBy(b=> b.Title)
            //        .Select(b=>b.Title);

            books.Where(b => b.Price < 8);
            books.SingleOrDefault();
            books.First();
            books.Last();
            books.Min();
            books.Max();
            books.Count();
            books.Skip(2).Take(1);

        }
    }
}
