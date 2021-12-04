using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BookStore.DTOs;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookServices.GetAll();
            Thread.Sleep(500);
            return Ok(books.Count == 0
                ? new ResponseSuccess<List<BookDto>>(new List<BookDto>())
                : new ResponseSuccess<List<BookDto>>(books));
        }
    }
}