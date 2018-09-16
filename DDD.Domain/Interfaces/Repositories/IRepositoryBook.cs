using System.Collections.Generic;
using DDD.Domain.Arguments.Book;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBook
    {
        int AddBook(AddBookRequest request);
        int EditBook(EditBookRequest request);
        string DeleteBook(DeleteBookRequest request);
        IEnumerable<BookResponse> ListAllBook();
    }
}