using DDD.Domain.Arguments.Exemplary;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceExemplary
    {
        AddExemplaryResponse Add(AddExemplaryRequest request);
        GetExemplaryResponse GetCount(GetExemplaryRequest request);
    }
}