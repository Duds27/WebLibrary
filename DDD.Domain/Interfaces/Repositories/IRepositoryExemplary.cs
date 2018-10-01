using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories.Base;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryExemplary : IRepositoryBase<Exemplary, int>
    {
        Task AddExemplary(Exemplary entidade);

        Task UpdateExemplary(Exemplary entidade);

        Task DeleteExemplary(Exemplary entidade);

        Task<IEnumerable<Exemplary>> ListAllExemplary();
        
        Task<Exemplary> FindById(int id);
    }
}