namespace DDD.Domain.ValueObjects
{
    public class Exemplary_Id
    {
        protected Exemplary_Id()
        {

        }

        public Exemplary_Id(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}