namespace DDD.Domain.ValueObjects
{
    public class Exemplary_Id
    {
        protected Exemplary_Id ()
        {

        }

        public Exemplary_Id (int id)
        {
            ValidateValues(id);
            SetProperties(id);
        }

        private void ValidateValues(int id)
        {
            DomainException.When((id <= 0), "ID do Exemplar é obrigatório!");
        }

        private void SetProperties(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}