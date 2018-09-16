using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class AddExemplaryResponse : IResponse
    {
        public int Exemplary_Id { get; set; }
        public string Message { get; set; }
    }
}