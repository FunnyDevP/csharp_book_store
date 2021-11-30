using System.Collections.Generic;
using System.Linq;
using BookStore.DTOs;
using BookStore.Models;
using BookStore.Repositories;
using BookStore.Services.Interfaces;

namespace BookStore.Services
{
    public class BookServices : IBookServices
    {
        private readonly IRepository<BookModel> _bookRepository;
        private readonly IRepository<BookCategoryModel> _bookCateRepository;

        public BookServices(IRepository<BookModel> bookRepository, IRepository<BookCategoryModel> bookCateRepository)
        {
            _bookRepository = bookRepository;
            _bookCateRepository = bookCateRepository;
        }


        public List<BookDto> GetAll()
        {
            var bookData = _bookRepository.GetAll();
            if (bookData.Count == 0)
            {
                return new List<BookDto>();
            }

            var bookCate = _bookCateRepository.GetAll();
            if (bookCate.Count == 0)
            {
                return new List<BookDto>();
            }

            var joined = bookData.Join(bookCate, b => b.CategoryId, c => c.Id,
                (b, c) => new BookModel
                {
                    Id = b.Id,
                    CategoryId = c.Id,
                    Category = c,
                    Name = b.Name,
                    Author = b.Author,
                    Price = b.Price,
                    PublicationAt = b.PublicationAt,
                    CreatedAt = b.CreatedAt
                }).ToList();

            var groupBookByCateId = joined
                .GroupBy(g => g.Category.Id)
                .Select(data => new BookDto(data.Key, data.ToList())).ToList();

            return groupBookByCateId;
        }
    }
}