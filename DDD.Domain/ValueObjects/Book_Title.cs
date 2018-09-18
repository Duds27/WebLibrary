namespace DDD.Domain.ValueObjects
{
    public class Book_Title
    {
        protected Book_Title()
        {

        }

        public Book_Title (string title)
        {
            ValidateValues(title);
            SetProperties(title);
        }

        private void ValidateValues(string title)
        {
            DomainException.When(string.IsNullOrEmpty(title), "Título do Livro é obrigatório!");
        }

        private void SetProperties(string title)
        {
            Title = title;
        }
        public string Title { get; private set; }
    }
}