using System.Collections.Generic;

namespace LamdaExpressions
{
    public class BookRepo
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1", Price = 20 },
                new Book() { Title = "Title 2", Price = 15 },
                new Book() { Title = "Title 3", Price = 5 }
            };
        }
    }
}
