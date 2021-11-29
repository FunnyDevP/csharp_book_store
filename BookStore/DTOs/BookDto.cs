using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.Models;

namespace BookStore.DTOs
{
    public class BookDto
    {
        public BookDto(Guid categoryId, List<BookModel> bookModels)
        {
            CategoryId = categoryId;
            CategoryName = bookModels.Find(b => b.Category.Id == categoryId)?.Category.Name;
            Books = bookModels.Select(b => new BookDtoInform(b)).ToList();
        }

        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<BookDtoInform> Books { get; set; }
    }

    public class BookDtoInform
    {
        public BookDtoInform(BookModel bookModel)
        {
            Id = bookModel.Id;
            Name = bookModel.Name;
            Author = bookModel.Author;
            Price = bookModel.Price;
            CreatedAt = bookModel.CreatedAt;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}