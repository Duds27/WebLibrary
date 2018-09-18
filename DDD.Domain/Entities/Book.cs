using System;
using DDD.Domain.Entities.Base;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Book : EntityBase
    {
        protected Book()
        {
            
        }

        public Book(string book_Title, string book_Description, string book_Author, string book_Publishing_Company, double book_Price)
        {
            ValidateValues(book_Title, book_Description, book_Author, book_Publishing_Company, book_Price);
            SetProperties(book_Title, book_Description, book_Author, book_Publishing_Company, book_Price);
        }

        public void UpdateBook(string book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            ValidateValues(book_title, book_description, book_author, book_publishing_company, book_price);
            SetProperties(book_title, book_description, book_author, book_publishing_company, book_price);
        }

        private static void ValidateValues (string book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            DomainException.When(string.IsNullOrEmpty(book_title), "Título do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_description), "Descrição do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_author), "Autor do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_publishing_company), "Editora do Livro é obrigatório!");
            DomainException.When((book_price <= 0.00), "Preço do Livro não pode ser de graça ou negativo!");
        }

        private void SetProperties(string book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            Book_Title              = book_title;
            Book_Description        = book_description;
            Book_Author             = book_author;
            Book_Publishing_Company = book_publishing_company;
            Book_Price              = book_price;
        }

        public string Book_Title { get; private set; }
        public string Book_Description { get; private set; }
        public string Book_Author { get; private set; }
        public string Book_Publishing_Company { get; private set; }
        public double Book_Price { get; private set; }      

        public override string ToString()
        {
            return $"Book_Id: {Id}\nTítulo: {Book_Title}\nDescrição: {Book_Description}\nAutor: {Book_Author}\nEditora: {Book_Publishing_Company}\nPreço: {Convert.ToString(Book_Price)}";
        }  
    }
}