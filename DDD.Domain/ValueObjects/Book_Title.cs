namespace DDD.Domain.ValueObjects
{
    public class Book_Title
    {
        protected Book_Title ()
        {

        }

        public Book_Title (string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
    }
}