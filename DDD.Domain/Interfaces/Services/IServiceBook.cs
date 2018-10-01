using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        Task AddBook(Book request);
        Task<Book> GetBookById(int id);
        Task EditBook(Book request);
        Task DeleteBook(Book request);
        Task<IEnumerable<Book>> ListAllBook();        
    }
}