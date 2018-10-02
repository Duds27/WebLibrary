using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Services
{
    public class ServiceBook : IServiceBook
    {
        private readonly IRepositoryBook _repositoryBook;

        public ServiceBook(IRepositoryBook repositoryBook)
        {
            _repositoryBook = repositoryBook;
        }

        public async Task AddBook(Book request)
        {
            if (! _repositoryBook.Existe(b => b.Book_Title == request.Book_Title))
            {
                await _repositoryBook.AddBook(request);
            }
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _repositoryBook.FindById(id);
        }
        
        public async Task<IEnumerable<Book>> ListAllBook()
        {
            return await _repositoryBook.ListAllBook();
        }

        public async Task<IEnumerable<Book>> ListAllBookByTitle()
        {
            return await _repositoryBook.ListAllBookByTitle();
        }

        public async Task EditBook(Book request)
        {
            await _repositoryBook.UpdateBook(request);
        }

        public async Task DeleteBook(Book request)
        {
            await _repositoryBook.DeleteBook(request);
        }

    }
}