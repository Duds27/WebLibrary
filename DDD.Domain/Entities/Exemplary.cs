using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities
{
    public class Exemplary
    {
        protected Exemplary ()
        {

        }

        public Exemplary (Exemplary_Id exemplary_id, Book_Id book_id, int exemplary_count)
        {
            ValidateValues(exemplary_id, book_id, exemplary_count);
            SetProperties(exemplary_id, book_id, exemplary_count);
        }

        public Exemplary (Exemplary_Id exemplary_id, Book_Id book_id)
        {
            ValidateValues(exemplary_id, book_id);
            SetProperties(exemplary_id, book_id, 0);
        }

        public Exemplary (Book_Id book_id, int exemplary_count)
        {
            ValidateValues(book_id, exemplary_count);
            SetProperties(book_id, exemplary_count);
        }

        public Exemplary (Book_Id book_id)
        {
            ValidateValues(book_id);
            SetProperties(book_id);
        }

        public void UpdateExemplary(Book_Id book_id, int exemplary_count)
        {
            ValidateValues(book_id, exemplary_count);
            SetProperties(book_id, exemplary_count);
        }

        private void ValidateValues(Exemplary_Id exemplary_id, Book_Id book_id, int exemplary_count)
        {
            DomainException.When((exemplary_id.Id <= 0), "ID do Exemplar é obrigatório!");
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
            DomainException.When((exemplary_count <= 0), "Quantidade de Exemplares não pode ser zero ou negativo!");
        }

        private void ValidateValues(Exemplary_Id exemplary_id, Book_Id book_id)
        {
            DomainException.When((exemplary_id.Id <= 0), "ID do Exemplar é obrigatório!");
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
        }

        private void ValidateValues(Book_Id book_id, int exemplary_count)
        {
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
            DomainException.When((exemplary_count <= 0), "Quantidade de Exemplares não pode ser zero ou negativo!");
        }

        private void ValidateValues(Book_Id book_id)
        {
            DomainException.When((book_id.Id <= 0), "ID do Livro é obrigatório!");
        }

        private void SetProperties(Exemplary_Id exemplary_id, Book_Id book_id, int exemplary_count)
        {
            Exemplary_Id    = exemplary_id;
            Book_Id         = book_id;
            Exemplary_Count = exemplary_count;
        }

        private void SetProperties(Book_Id book_id, int exemplary_count)
        {
            Book_Id         = book_id;
            Exemplary_Count = exemplary_count;
        }

        private void SetProperties(Book_Id book_id)
        {
            Book_Id = book_id;
        }

        // Encapsulamento das Propriedades
        public Exemplary_Id Exemplary_Id { get; private set; }
        public Book_Id Book_Id { get; private set; }
        public int Exemplary_Count { get; private set; }
    }
}