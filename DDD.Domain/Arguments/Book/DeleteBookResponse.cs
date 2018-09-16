using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class DeleteBookResponse : IResponse
    {
        public string Message { get; set; }
    }
}