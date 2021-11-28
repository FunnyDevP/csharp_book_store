using System.Collections.Generic;
using BookStore.DTOs;

namespace BookStore.Services.Interfaces
{
    public interface IBookServices
    {
        List<BookDto> GetAll();
    }
}
