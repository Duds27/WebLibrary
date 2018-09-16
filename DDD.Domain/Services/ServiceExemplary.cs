using DDD.Domain.Arguments.Exemplary;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;
using DDD.Domain.ValueObjects;

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

            Exemplary exemplary = new Exemplary(new Book_Id(book_id), exemplary_count);

            /* TODO: criar validacoa  */

            exemplary = _repositoryExemplary.AddExemplary(exemplary);

            return  (AddExemplaryResponse) exemplary;
        }

        public GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request)
        {
            var book_id = request.Book_Id;

            Exemplary exemplary = new Exemplary(book_id);

            /* TODO: criar validacao */
            
            exemplary = _repositoryExemplary.GetExemplaryCount(exemplary);

            return (GetExemplaryResponse) exemplary;
        }
    }
}