using DDD.Domain.Arguments.Exemplary;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceExemplary
    {
        AddExemplaryResponse AddExemplary(AddExemplaryRequest request);
        GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request);
    }
}