using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class EditBookResponse : IResponse
    {
        public int Book_id { get; set; }
        public string Message { get; set; }
    }
}