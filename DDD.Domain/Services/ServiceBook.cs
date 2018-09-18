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
            var book_title              = request.Book_Title;
            var book_description        = request.Book_Description;
            var book_author             = request.Book_Author;
            var book_publishing_company = request.Book_Publishing_Company;
            var book_price              = request.Book_Price;

            Book book = new Book(book_title, book_description, book_author, book_publishing_company, book_price);

            if (! _repositoryBook.Existe(b => b.Book_Title == request.Book_Title))
            {
                return (AddBookResponse) _repositoryBook.Adicionar(book);
            }

            return null;
        }

        public UpdateBookResponse UpdateBook(UpdateBookRequest request)
        {
            if (request == null)
            {
                return null;
            }

            Book book = _repositoryBook.ObterPorId(request.Book_Id);

            if (book != null)
            {
                var book_title              = request.Book_Title;
                var book_description        = request.Book_Description;
                var book_author             = request.Book_Author;
                var book_publishing_company = request.Book_Publishing_Company;
                var book_price              = request.Book_Price;

                book = new Book(book_title, book_description, book_author, book_publishing_company, book_price);
                            
                book = _repositoryBook.Editar(book);
                
                return (UpdateBookResponse) book;
            }

            return null;
        }

        public DeleteBookResponse DeleteBook(DeleteBookRequest request)
        {
            Book book = _repositoryBook.ObterPor(b => b.Book_Title == request.Book_Title);

            if (book != null)
            {
                _repositoryBook.Remover(book);

                return new DeleteBookResponse() { Message = "Livro deletado com sucesso!" };
            }

            return null;
        }

        public IEnumerable<BookResponse> ListAllBook()
        {
            return _repositoryBook.Listar().ToList().Select(book => (BookResponse) book).OrderBy(b => b.Book_Title).ToList();
        }        

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}