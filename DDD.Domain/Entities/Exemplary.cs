using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Exemplary
    {
        protected Exemplary ()
        {

        }

        public Exemplary (Exemplary_Id exemplary_id, Book_Id book_id)
        {
            DomainException.When((exemplary_id <= 0), "ID do Exemplar é obrigatório!");
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");

            Exemplary_Id = exemplary_id;
            Book_Id      = book_id;
        }

        public Exemplary_Id Exemplary_Id { get; private set; }
        public Book_Id Book { get; private set; }
        public int Exemplary_Count { get; set; }
    }
}