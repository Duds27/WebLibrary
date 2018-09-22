using DDD.Domain.Arguments;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        AddBookResponse AddBook(AddBookRequest request);
        // EditBookResponse EditBook(EditBookRequest request);
        // DeleteBookResponse DeleteBook(DeleteBookRequest request);
        // IEnumerable<BookResponse> ListAllBook();
    }
}