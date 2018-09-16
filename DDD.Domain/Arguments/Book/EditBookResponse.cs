using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class EditBookResponse : IResponse
    {
        public string Message { get; set; }
    }
}