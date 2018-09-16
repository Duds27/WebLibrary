using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class GetExemplaryResponse : IResponse
    {
        public int Book_Id { get; set; }
        public int Exemplary_Count { get; set; }
    }
}