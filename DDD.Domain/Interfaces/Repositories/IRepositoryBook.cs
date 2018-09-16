using System.Collections.Generic;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;

namespace DDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBook
    {
        Book AddBook(Book book);
        Book EditBook(Book book);
        void DeleteBook(Book book);
        IEnumerable<Book> ListAllBook();
    }
}