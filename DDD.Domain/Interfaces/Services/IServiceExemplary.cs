using DDD.Domain.Arguments.Exemplary;
using DDD.Domain.Interfaces.Services.Base;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceExemplary : IServiceBase
    {
        AddExemplaryResponse AddExemplary(AddExemplaryRequest request);
        GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request);
    }
}