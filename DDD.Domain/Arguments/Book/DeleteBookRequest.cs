using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class DeleteBookRequest : IRequest
    {
        public string Book_Title { get; set; }
    }
}