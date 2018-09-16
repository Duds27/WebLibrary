namespace DDD.Domain.ValueObjects
{
    public class Book_Id
    {
        protected Book_Id ()
        {

        }

        public Book_Id (int id)
        {
            ValidateValues(id);
            SetProperties(id);
        }

        private void ValidateValues(int id)
        {
            DomainException.When((id <= 0), "ID do Livro é obrigatório!");
        }

        private void SetProperties(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}