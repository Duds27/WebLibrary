using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Arguments.Book;
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
            var book_title              = request.Book_Title;
            var book_description        = request.Book_Description;
            var book_author             = request.Book_Author;
            var book_publishing_company = request.Book_Publishing_Company;
            var book_price              = request.Book_Price;

            //Book book = new Book(book_title, book_description, book_author, book_publishing_company, book_price);

            if (! _repositoryBook.Existe(b => b.Book_Title == request.Book_Title))
            {
                await _repositoryBook.AddBook(request);
            }
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _repositoryBook.FindById(id);
        }

        // public async Task<Book> GetBookByTitle(string book_Title)
        // {   
        //     if (book_Title != null)
        //     {
        //         return await _repositoryBook.FindByTitle(book_Title);
        //     }
        //     return null;
        // }

        public async Task<IEnumerable<Book>> ListAllBook()
        {
            return await _repositoryBook.ListAllBook();
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