using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using DDD.Infra.Persistence.Repositories.Base;

namespace DDD.Infra.Persistence.Repositories
{
    public class RepositoryExemplary : RepositoryBase<Exemplary, int>, IRepositoryExemplary
    {
        protected readonly LibraryContext _context;

        public RepositoryExemplary(LibraryContext context) : base(context)
        {
            _context = context;
        }
    }
}