using System;
using System.Collections.Generic;
using BookStore.DTOs;
using BookStore.Models;
using BookStore.Repositories;
using BookStore.Services;
using Moq;
using Xunit;

namespace BookStore.Test.Services
{
    public class BookServicesTest
    {
        [Fact]
        public void GetAll_BookDataOnDbIsEmpty_ReturnEmptyListOfBookDto()
        {
            var mockBookRepo = new Mock<IRepository<BookModel>>();
            mockBookRepo.Setup(r => r.GetAll()).Returns(new List<BookModel>());

            var service = new BookServices(mockBookRepo.Object, null);
            var resultGetAll = service.GetAll();

            Assert.Empty(resultGetAll);
            mockBookRepo.Verify(v => v.GetAll(), Times.Once);
        }

        [Fact]
        public void GetAll_BookCategoryOnDbIsEmpty_ReturnEmptyListOfBookDto()
        {
            var mockBookRepo = new Mock<IRepository<BookModel>>();
            var mockBookCateRepo = new Mock<IRepository<BookCategoryModel>>();
            mockBookRepo.Setup(r => r.GetAll()).Returns(SetupBookData());
            mockBookCateRepo.Setup(r => r.GetAll()).Returns(new List<BookCategoryModel>());

            var service = new BookServices(mockBookRepo.Object, mockBookCateRepo.Object);
            var resultGetAll = service.GetAll();

            Assert.Empty(resultGetAll);
            mockBookRepo.Verify(v => v.GetAll(), Times.Once);
            mockBookCateRepo.Verify(v => v.GetAll(), Times.Once);
        }

        [Fact]
        public void GetAll_GetBookCollectionsWithData_ReturnListOfBookDto()
        {
            var mockBookRepo = new Mock<IRepository<BookModel>>();
            var mockBookCateRepo = new Mock<IRepository<BookCategoryModel>>();
            mockBookRepo.Setup(r => r.GetAll()).Returns(SetupBookData());
            mockBookCateRepo.Setup(r => r.GetAll()).Returns(SetupBookCate());

            var service = new BookServices(mockBookRepo.Object, mockBookCateRepo.Object);
            var resultGetAll = service.GetAll();

            Assert.Equal(2, resultGetAll.Count);

            var bookCate1 = resultGetAll[0];
            Assert.Equal("7e68d435-e561-4fb5-be87-ee8c6efe7d28", bookCate1.CategoryId.ToString());
            Assert.Equal("cate_1", bookCate1.CategoryName);
            var bookCate1Books = bookCate1.Books;
            Assert.Equal(2, bookCate1Books.Count);
            var cate1Book1 = bookCate1Books[0];
            Assert.Equal("1bc7b0ac-c5c6-480d-a258-7a6285565b30", cate1Book1.Id.ToString());
            Assert.Equal("book_name_1", cate1Book1.Name);
            Assert.Equal("book_author_1", cate1Book1.Author);
            Assert.Equal(new decimal(11.11), cate1Book1.Price);
            var cate1Book2 = bookCate1Books[1];
            Assert.Equal("dac5490d-b0ab-4d8d-83d9-e81d5927b6be", cate1Book2.Id.ToString());
            Assert.Equal("book_name_3", cate1Book2.Name);
            Assert.Equal("book_author_3", cate1Book2.Author);
            Assert.Equal(new decimal(11.11), cate1Book2.Price);

            var bookCate2 = resultGetAll[1];
            Assert.Equal("2ae03aa7-2b39-4b0b-b76a-ec22872cfec6", bookCate2.CategoryId.ToString());
            Assert.Equal("cate_2", bookCate2.CategoryName);
            var books = bookCate2.Books;
            Assert.Equal(2, books.Count);
            var books1 = books[0];
            Assert.Equal("38844a97-4666-4289-897a-17b45bb5b386", books1.Id.ToString());
            Assert.Equal("book_name_2", books1.Name);
            Assert.Equal("book_author_2", books1.Author);
            Assert.Equal(new decimal(11.11), books1.Price);
            var books2 = books[1];
            Assert.Equal("60183e5c-06d2-4d6f-937c-f1b0b37291c0", books2.Id.ToString());
            Assert.Equal("book_name_4", books2.Name);
            Assert.Equal("book_author_4", books2.Author);
            Assert.Equal(new decimal(11.11), books2.Price);

            mockBookRepo.Verify(v => v.GetAll(), Times.Once);
            mockBookCateRepo.Verify(v => v.GetAll(), Times.Once);
        }

        private List<BookModel> SetupBookData()
        {
            return new List<BookModel>
            {
                new()
                {
                    Id = new Guid("1bc7b0ac-c5c6-480d-a258-7a6285565b30"),
                    CategoryId = new Guid("7e68d435-e561-4fb5-be87-ee8c6efe7d28"),
                    Category = null,
                    Name = "book_name_1",
                    Author = "book_author_1",
                    Price = new decimal(11.11),
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = new Guid("38844a97-4666-4289-897a-17b45bb5b386"),
                    CategoryId = new Guid("2ae03aa7-2b39-4b0b-b76a-ec22872cfec6"),
                    Category = null,
                    Name = "book_name_2",
                    Author = "book_author_2",
                    Price = new decimal(11.11),
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = new Guid("dac5490d-b0ab-4d8d-83d9-e81d5927b6be"),
                    CategoryId = new Guid("7e68d435-e561-4fb5-be87-ee8c6efe7d28"),
                    Category = null,
                    Name = "book_name_3",
                    Author = "book_author_3",
                    Price = new decimal(11.11),
                    CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = new Guid("60183e5c-06d2-4d6f-937c-f1b0b37291c0"),
                    CategoryId = new Guid("2ae03aa7-2b39-4b0b-b76a-ec22872cfec6"),
                    Category = null,
                    Name = "book_name_4",
                    Author = "book_author_4",
                    Price = new decimal(11.11),
                    CreatedAt = DateTime.Now
                },
            };
        }

        private List<BookCategoryModel> SetupBookCate()
        {
            return new List<BookCategoryModel>
            {
                new()
                {
                    Id = new Guid("7e68d435-e561-4fb5-be87-ee8c6efe7d28"),
                    Name = "cate_1"
                },
                new()
                {
                    Id = new Guid("2ae03aa7-2b39-4b0b-b76a-ec22872cfec6"),
                    Name = "cate_2"
                },
            };
        }
    }
}
