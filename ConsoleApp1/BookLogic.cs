using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookLogic : IBookLogicInterface 
    {

        //private BookDataAccess dataAccess; tightly coupled

        private IbookDataAccessInterface dataAccess; // losssly coupled
        public BookLogic(IbookDataAccessInterface bookDa)
        {
            dataAccess = bookDa;
           // dataAccess = new BookDataAccess(); 
            // This is a tightly coupled dependency injection
            // There is a priciple that say that hogher level object should not be dependepent on lower level objects.
            // Both dependent on abstraction which is interfaces.
        }
        public List<Book> GetBooks()
        {
            return dataAccess.GetBooks();
        }

        public Book GetBookByTitle(string title)
        {
            return dataAccess.GetBookByTitle(title);
        }
    }
}
