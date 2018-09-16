using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Book
    {
        protected Book ()
        {

        }

        public Book (Book_Id book_id, Book_Title book_title)
        {
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
            DomainException.When(string.IsNullOrEmpty(book_title), "Título do Livro é obrigatório!");

            Book_Id    = book_id;
            Book_Title = book_title;
        }

        public Book_Id Book_Id { get; private set; }
        public Book_Title Book_Title { get; private set; }
        public string Book_Description { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publishing_Company { get; set; }
        public double Book_Price { get; set; }
    }
}