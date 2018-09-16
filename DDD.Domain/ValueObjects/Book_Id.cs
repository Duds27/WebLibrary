namespace DDD.Domain.ValueObjects
{
    public class Book_Id
    {
        protected Book_Id ()
        {

        }

        public Book_Id (int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}