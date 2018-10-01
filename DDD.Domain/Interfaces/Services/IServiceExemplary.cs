using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceExemplary
    {
        Task AddExemplary(Exemplary request);
        Task<Exemplary> GetExemplaryById(int id);
        Task EditExemplary(Exemplary request);
        Task DeleteExemplary(Exemplary request);
        Task<IEnumerable<Exemplary>> ListAllExemplary();
    }

}