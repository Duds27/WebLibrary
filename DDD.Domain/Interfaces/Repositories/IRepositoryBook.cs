using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using DDD.Domain.Interfaces.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBook : IRepositoryBase<Book, int>
    {
        Task AddBook(Book entidade);
        Task UpdateBook(Book entidade);
        void DeleteBook(Book entidade);
        Task<IEnumerable<Book>> ListAllBook();
        // Task<Book> FindByTitle(string book_Title);
        Task<Book> FindById(int id);
    }
}