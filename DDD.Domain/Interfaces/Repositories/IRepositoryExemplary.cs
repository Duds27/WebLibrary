using DDD.Domain.Arguments.Exemplary;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryExemplary
    {
        int AddExemplary(AddExemplaryRequest request);
        GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request);
    }
}