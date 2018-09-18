using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories.Base;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBook : IRepositoryBase<Book, int>
    {
         
    }
}