using DDD.Domain.Entities.Base;

namespace DDD.Domain.Entities
{
    public class Exemplary : EntityBase
    {
        protected Exemplary ()
        {

        }
        
        public Exemplary(int book_Id, int exemplary_Count)
        {
            Book_Id = book_Id;
            Exemplary_Count = exemplary_Count;
        }

        public void UpdateExemplary(int book_id, int exemplary_count)
        {
            ValidateValues(book_id, exemplary_count);
            SetProperties(book_id, exemplary_count);
        }

        private void ValidateValues(int book_id, int exemplary_count)
        {
            DomainException.When((book_id <= 0), "ID do Livro é obrigatório!");
            DomainException.When((exemplary_count <= 0), "Quantidade de Exemplares não pode ser zero ou negativo!");
        }

        private void SetProperties(int book_id, int exemplary_count)
        {
            Book_Id         = book_id;
            Exemplary_Count = exemplary_count;
        }

        public int Book_Id { get; private set; }
        public int Exemplary_Count { get; private set; }
    }
}