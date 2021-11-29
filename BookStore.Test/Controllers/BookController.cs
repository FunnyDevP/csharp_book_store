using System;
using System.Collections.Generic;
using BookStore.Controllers;
using BookStore.DTOs;
using BookStore.Models;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace BookStore.Test.Controllers
{
    public class BookControllerTest
    {
        [Fact]
        public void GetAll_GotEmptyDataFromDB_Return200AndEmptyListInResponseBody()
        {
            var mockService = new Mock<IBookServices>();
            mockService.Setup(s => s.GetAll()).Returns(new List<BookDto>());

            var ctrl = new BookController(mockService.Object);
            var result = ctrl.GetAll();
            var ok = result as OkObjectResult;

            Assert.NotNull(ok);
            Assert.Equal(200, ok.StatusCode);
            var respBody = ok.Value as ResponseSuccess<List<BookDto>>;
            Assert.NotNull(respBody);
            Assert.Empty(respBody.Data);

            mockService.Verify(s => s.GetAll(), Times.Once);
        }

        [Fact]
        public void GetAll_GetBooksFromDB_Return200WithData()
        {
            var mockService = new Mock<IBookServices>();
            mockService.Setup(s => s.GetAll()).Returns(SetupBooks());

            var ctrl = new BookController(mockService.Object);
            var result = ctrl.GetAll();
            var ok = result as OkObjectResult;

            Assert.NotNull(ok);
            Assert.Equal(200, ok.StatusCode);
            var respBody = ok.Value as ResponseSuccess<List<BookDto>>;
            Assert.NotNull(respBody);
            Assert.Equal(2, respBody.Data.Count);

            var cate1 = respBody.Data[0];
            Assert.Equal("e3d8f80e-79eb-4d98-8fed-46f9b144631f", cate1.CategoryId.ToString());
            Assert.Equal("cate_1", cate1.CategoryName);
            Assert.Single(cate1.Books);
            Assert.Equal("1bc7b0ac-c5c6-480d-a258-7a6285565b30", cate1.Books[0].Id.ToString());
            Assert.Equal("book_name_1", cate1.Books[0].Name);
            Assert.Equal("book_author_1", cate1.Books[0].Author);
            Assert.Equal(new decimal(11.11), cate1.Books[0].Price);

            var cate2 = respBody.Data[1];
            Assert.Equal("43ca6108-4e0c-41b7-a653-1c69e916831b", cate2.CategoryId.ToString());
            Assert.Equal("cate_2", cate2.CategoryName);
            Assert.Single(cate2.Books);
            Assert.Equal("dac5490d-b0ab-4d8d-83d9-e81d5927b6be", cate2.Books[0].Id.ToString());
            Assert.Equal("book_name_3", cate2.Books[0].Name);
            Assert.Equal("book_author_3", cate2.Books[0].Author);
            Assert.Equal(new decimal(11.11), cate2.Books[0].Price);
            mockService.Verify(s => s.GetAll(), Times.Once);
        }

        private List<BookDto> SetupBooks()
        {
            return new List<BookDto>
            {
                new(
                    new Guid("e3d8f80e-79eb-4d98-8fed-46f9b144631f"),
                    new List<BookModel>
                    {
                        new()
                        {
                            Id = new Guid("1bc7b0ac-c5c6-480d-a258-7a6285565b30"),
                            CategoryId = new Guid("e3d8f80e-79eb-4d98-8fed-46f9b144631f"),
                            Category = new BookCategoryModel
                            {
                                Id = new Guid("e3d8f80e-79eb-4d98-8fed-46f9b144631f"),
                                Name = "cate_1"
                            },
                            Name = "book_name_1",
                            Author = "book_author_1",
                            Price = new decimal(11.11),
                            CreatedAt = DateTime.Now
                        }
                    }
                ),
                new(
                    new Guid("43ca6108-4e0c-41b7-a653-1c69e916831b"),
                    new List<BookModel>
                    {
                        new()
                        {
                            Id = new Guid("dac5490d-b0ab-4d8d-83d9-e81d5927b6be"),
                            CategoryId = new Guid("43ca6108-4e0c-41b7-a653-1c69e916831b"),
                            Category = new BookCategoryModel
                            {
                                Id = new Guid("43ca6108-4e0c-41b7-a653-1c69e916831b"),
                                Name = "cate_2"
                            },
                            Name = "book_name_3",
                            Author = "book_author_3",
                            Price = new decimal(11.11),
                            CreatedAt = DateTime.Now
                        }
                    }
                ),
            };
        }
    }
}