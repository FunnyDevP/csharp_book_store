using System.Collections.Generic;
using System.Linq;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Repositories
{
    public class BookCategoryRepository: IRepository<BookCategoryModel>
    {
        private readonly BookCategoryContext _bookCategoryContext;

        public BookCategoryRepository(BookCategoryContext bookCategoryContext)
        {
            _bookCategoryContext = bookCategoryContext;
        }

        public List<BookCategoryModel> GetAll()
        {
            return _bookCategoryContext.BookCategories.ToList();
        }
    }
}