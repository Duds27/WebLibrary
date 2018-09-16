using DDD.Domain.Arguments.Exemplary;
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
            int id = _repositoryExemplary.AddExemplary(request);

            return new AddExemplaryResponse() { Exemplary_Id = id, Message = "Exemplar adicionado com sucesso!" };
        }

        public GetExemplaryResponse GetExemplaryCount(GetExemplaryRequest request)
        {
            return _repositoryExemplary.GetExemplaryCount(request);
        }
    }
}