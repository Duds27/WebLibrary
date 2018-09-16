using DDD.Domain.Arguments.Exemplary;
using DDD.Domain.Entities;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryExemplary
    {
        Exemplary AddExemplary(Exemplary exemplary);
        Exemplary GetExemplaryCount(Exemplary exemplaryId);
    }
}