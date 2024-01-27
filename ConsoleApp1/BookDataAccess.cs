using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookDataAccess : IbookDataAccessInterface
    {
        private List<Book> books;

        public BookDataAccess()
        {
            books = new List<Book>()
            {
                new Book {Title = "Northanger Abbey", Description= "Austen, Jane, year_written: 1814, edition: Penguin, price:  18.2"},
new Book {Title = "War and Peace", Description= "Tolstoy, Leo, year_written: 1865, edition: Penguin"},
new Book {Title ="Anna Karenina", Description= "Tolstoy, Leo, year_written: 1875, edition: Penguin"},
            };
        }
        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookByTitle(string title)
        {
            try
            {
                var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                return book;
            }
            catch
            {
                return null;
            }
        }
    }
}
