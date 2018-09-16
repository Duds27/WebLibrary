using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Book
    {
        protected Book ()
        {

        }

        public Book (Book_Id book_id, Book_Title book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            ValidateValues(book_id, book_title, book_description, book_author, book_publishing_company, book_price);
            SetProperties(book_id, book_title, book_description, book_author, book_publishing_company, book_price);
        }

        public void Update (Book_Id book_Id, Book_Title book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            ValidateValues(book_id, book_title, book_description, book_author, book_publishing_company, book_price);
            SetProperties(book_id, book_title, book_description, book_author, book_publishing_company, book_price);
        }

        private void SetProperties(Book_Id book_id, Book_Title book_title, string book_description, string book_author, string book_publishing_company, double book_price)
        {
            Book_Id                 = book_id;
            Book_Title              = book_title;
            Book_Description        = book_description;
            Book_Author             = book_author;
            Book_Publishing_Company = book_publishing_company;
            Book_Price              = book_price;
        }

        private static void ValidateValues (Book_Id book_id, Book_Title book_title, string book_description, string book_author, string book_publishing_company, string book_price)
        {
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_title), "Título do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_description), "Descrição do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_author), "Autor do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_publishing_company), "Editora do Livro é obrigatório!");
            DomainException.When((book_price <= 0.00), "Preço do Livro não pode ser de graça ou negativo!");
        }

        public Book_Id Book_Id { get; private set; }
        public Book_Title Book_Title { get; private set; }
        public string Book_Description { get; private set; }
        public string Book_Author { get; private set; }
        public string Book_Publishing_Company { get; private set; }
        public double Book_Price { get; private set; }
    }
}