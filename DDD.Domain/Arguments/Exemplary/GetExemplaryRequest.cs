using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class GetExemplaryRequest : IRequest
    {
        public int Book_Id { get; set; }
    }
}