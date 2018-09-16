using System.Collections.Generic;
using DDD.Domain.Arguments.Book;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        AddBookResponse Add(AddBookRequest request);
        EditBookResponse Edit(EditBookRequest request);
        DeleteBookResponse Delete(DeleteBookRequest request);
        IEnumerable<BookResponse> ListAllBook();
    }
}