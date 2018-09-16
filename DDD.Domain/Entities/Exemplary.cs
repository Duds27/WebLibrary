using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Exemplary
    {
        protected Exemplary()
        {

        }

        public Exemplary(Exemplary_Id exemplary_id, Book_Id book_id)
        {
            Exemplary_Id = exemplary_id;
            Book_Id      = book_id;
        }

        public Exemplary_Id Exemplary_Id { get; private set; }
        public Book_Id Book { get; private set; }
        public int Exemplary_Count { get; set; }
    }
}