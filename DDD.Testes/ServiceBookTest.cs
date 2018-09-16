using System;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;
using DDD.Domain.Services;
using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDD.Testes
{
    [TestClass]
    public class ServiceBookTest
    {
        // Variavies utilizadas em todos os casos de teste
        private Book[] books = {
            new Book(new Book_Id(1), new Book_Title("Livro Z"), "Descrição do Livro Z", "Erase",    "Ed. Apagar Livro",          428.75),
            new Book(new Book_Id(2), new Book_Title("Livro B"), "Descrição do Livro B", "Carlos",   "Ed. Engenharia Para Todos", 536.43),
            new Book(new Book_Id(3), new Book_Title("Livro E"), "Descrição do Livro E", "Henrique", "Ed. Novo Horizonte",        764.67),
            new Book(new Book_Id(4), new Book_Title("Livro D"), "Descrição do Livro D", "Alex",     "Ed. Mundo Globalizado",     68.45),
            new Book(new Book_Id(5), new Book_Title("Livro A"), "Descrição do Livro A", "Eduardo",  "Ed. Computação",            635.34),
            new Book(new Book_Id(6), new Book_Title("Livro C"), "Descrição do Livro C", "Espinoza", "Ed. Geração XXI",           28.55),
            new Book(new Book_Id(7), new Book_Title("Livro F"), "Descrição do Livro F", "Junior",   "Ed. Pensadores",            428.75)
        };

        private AddBookRequest[] booksRequest = {
            new AddBookRequest() { Book_Title = "Livro Z", Book_Description = "Descrição do Livro Z", Book_Author = "Erase",    Book_Publishing_Company = "Ed. Apagar Livro",          Book_Price = 428.75 },
            new AddBookRequest() { Book_Title = "Livro B", Book_Description = "Descrição do Livro B", Book_Author = "Carlos",   Book_Publishing_Company = "Ed. Engenharia Para Todos", Book_Price = 536.43 },
            new AddBookRequest() { Book_Title = "Livro E", Book_Description = "Descrição do Livro E", Book_Author = "Henrique", Book_Publishing_Company = "Ed. Novo Horizonte",        Book_Price = 764.67 },
            new AddBookRequest() { Book_Title = "Livro D", Book_Description = "Descrição do Livro D", Book_Author = "Alex",     Book_Publishing_Company = "Ed. Mundo Globalizado",     Book_Price = 68.45 },
            new AddBookRequest() { Book_Title = "Livro A", Book_Description = "Descrição do Livro A", Book_Author = "Eduardo",  Book_Publishing_Company = "Ed. Computação",            Book_Price = 635.34 },
            new AddBookRequest() { Book_Title = "Livro C", Book_Description = "Descrição do Livro C", Book_Author = "Espinoza", Book_Publishing_Company = "Ed. Geração XXI",           Book_Price = 28.55 },
            new AddBookRequest() { Book_Title = "Livro F", Book_Description = "Descrição do Livro F", Book_Author = "Junior",   Book_Publishing_Company = "Ed. Pensadores",            Book_Price = 428.75 },
        };




        [TestMethod]
        public void TestMethod_ServiceBook_AddBook()
        {
            var service = new ServiceBook();

            AddBookRequest request = booksRequest[0];
            Assert.IsNotNull(request);

            Assert.AreEqual(books[0].Book_Title.Title, request.Book_Title);

            request = booksRequest[4];

            Assert.AreNotEqual(books[0].Book_Title.Title, request.Book_Title);
            
            var result = service.AddBook(request);
        }
    }
}