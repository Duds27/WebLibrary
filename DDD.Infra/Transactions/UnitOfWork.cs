using DDD.Infra.Persistence;

namespace DDD.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}