using DDD.Domain.Arguments.Exemplary;
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

        public AddExemplaryResponse AddExemplary(AddExemplaryRequest request)
        {
            var book_id         = request.Book_Id;
            var exemplary_count = request.Exemplary_Count;

            Exemplary exemplary = new Exemplary(book_id, exemplary_count);

            if (! _repositoryExemplary.Existe(e => e.Book_Id == request.Book_Id))
            {
                return (AddExemplaryResponse) _repositoryExemplary.Adicionar(exemplary);
            }

            return null;
        }

        public GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request)
        {
            if (request == null)
            {
                return null;
            }

            Exemplary exemplary = _repositoryExemplary.ObterPor(e => e.Book_Id == request.Book_Id);
            
            if (exemplary != null)
            {
                return (GetExemplaryResponse) exemplary;
            }

            return null;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}