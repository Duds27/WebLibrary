using System.Collections.Generic;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;

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
            int book_id = _repositoryBook.AddBook(request);

            return new AddBookResponse() { Book_Id = book_id, Message = "Livro adicionado com sucesso!" };
        }

        public DeleteBookResponse DeleteBook(DeleteBookRequest request)
        {
            string msg = _repositoryBook.DeleteBook(request);

            return new DeleteBookResponse() { Message = "Livro deletado com sucesso!" };
        }

        public EditBookResponse EditBook(EditBookRequest request)
        {
            int book_id = _repositoryBook.EditBook(request);

            return new EditBookResponse() { Book_id = book_id, Message = "Livro foi editado com sucesso!" };
        }

        public IEnumerable<BookResponse> ListAllBook()
        {
            return _repositoryBook.ListAllBook();
        }
    }
}