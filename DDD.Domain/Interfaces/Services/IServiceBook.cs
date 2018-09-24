using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        // Task AddBook(AddBookRequest request);
        Task AddBook(Book request);
        Task<Book> GetBookById(int id);
        // Task<Book> GetBookByTitle(string book_Title);
        Task EditBook(Book request);
        // DeleteBookResponse DeleteBook(DeleteBookRequest request);
        Task<IEnumerable<Book>> ListAllBook();        
    }
}