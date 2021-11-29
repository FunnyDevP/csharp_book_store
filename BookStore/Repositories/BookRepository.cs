using System.Collections.Generic;
using System.Linq;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Repositories
{
    public class BookRepository : IRepository<BookModel>
    {
        private readonly BookContext _bookContext;

        public BookRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public List<BookModel> GetAll()
        {
            return _bookContext.Books.ToList();
        }
    }
}