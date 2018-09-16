using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class AddBookResponse : IResponse
    {
        public int Book_Id { get; set; }
        public string Message { get; set; }
    }
}