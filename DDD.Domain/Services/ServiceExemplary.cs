using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;

namespace DDD.Domain.Services
{
    public class ServiceExemplary : IServiceExemplary
    {
        private readonly IRepositoryExemplary _repositoryExemplary;

        public ServiceExemplary(IRepositoryExemplary repositoryExemplary)
        {
            _repositoryExemplary = repositoryExemplary;
        }

        public async Task AddExemplary(Exemplary request)
        {
            if (! _repositoryExemplary.Existe(e => e.Book_Id == request.Book_Id))
            {
                await _repositoryExemplary.AddExemplary(request);
            }
        }

        public async Task<Exemplary> GetExemplaryById(int id)
        {
            return await _repositoryExemplary.FindById(id);
        }

        public async Task<IEnumerable<Exemplary>> ListAllExemplary()
        {
            return await _repositoryExemplary.ListAllExemplary();
        }

        public async Task EditExemplary(Exemplary request)
        {
            await _repositoryExemplary.UpdateExemplary(request);
        }

        public async Task DeleteExemplary(Exemplary request)
        {
            await _repositoryExemplary.DeleteExemplary(request);
        }
    }
}