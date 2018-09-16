using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class AdicionarExemplarRequest : IRequest
    {
        public int Book_Id { get; set; }
        public int Exemplary_Count { get; set; }
    }
}