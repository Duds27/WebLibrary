using System;
using System.Collections.Generic;
using System.Linq;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Services
{
    public class ServiceBook : IServiceBook
    {
        private readonly IRepositoryBook _repositoryBook;

        public ServiceBook(IRepositoryBook repositoryBook)
        {
            _repositoryBook = repositoryBook;
        }

        public AddBookResponse AddBook(AddBookRequest request)
        {            
            var book_title              = new Book_Title(request.Book_Title);
            var book_description        = request.Book_Description;
            var book_author             = request.Book_Author;
            var book_publishing_company = request.Book_Publishing_Company;
            var book_price              = request.Book_Price;

            /* TODO: Criar validacao para o book */
            
            Book book = new Book(book_title, book_description, book_author, book_publishing_company, book_price);
            
            book = _repositoryBook.AddBook(book);

            return (AddBookResponse) book;
        }

        public DeleteBookResponse DeleteBook(DeleteBookRequest request)
        {
            var book_title = new Book_Title(request.Book_Title);

            Book book = new Book(book_title, "", "", "", 0.0);
            
            string msg = _repositoryBook.DeleteBook(book_title);

            return new DeleteBookResponse() { Message = "Livro deletado com sucesso!" };
        }

        public EditBookResponse EditBook(EditBookRequest request)
        {
            var book_title              = new Book_Title(request.Book_Title);
            var book_description        = request.Book_Description;
            var book_author             = request.Book_Author;
            var book_publishing_company = request.Book_Publishing_Company;
            var book_price              = request.Book_Price;

            Book book = new Book(book_title, book_description, book_author, book_publishing_company, book_price);

            /* TODO: Criar validacao para o book */
                        
            book = _repositoryBook.EditBook(book);

            
            return (EditBookResponse) book;
        }

        public IEnumerable<BookResponse> ListAllBook()
        {
            return _repositoryBook.ListAllBook().ToList().Select(book => (BookResponse) book).ToList();
        }
    }
}