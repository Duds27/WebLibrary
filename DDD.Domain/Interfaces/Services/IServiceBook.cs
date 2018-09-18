using System.Collections.Generic;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Interfaces.Services.Base;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook : IServiceBase
    {
        AddBookResponse AddBook(AddBookRequest request);
        UpdateBookResponse UpdateBook(UpdateBookRequest request);
        DeleteBookResponse DeleteBook(DeleteBookRequest request);
        IEnumerable<BookResponse> ListAllBook();
    }
}