using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories.Base;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBook : IRepositoryBase<Book, int>
    {
        Task AddBook(Book entidade);
        Task UpdateBook(Book entidade);
        void DeleteBook(Book entidade);
        Task<IEnumerable<Book>> ListAllBook();
        Task<Book> Find(string key);
        Task<IEnumerable<Book>> GetAll();
    }
}