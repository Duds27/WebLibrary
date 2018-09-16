using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class BookResponse : IResponse
    {
        public int Book_Id { get; set; }
        public string Book_Title { get; set; }
        public string Book_Description { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publishing_Company { get; set; }
        public double Book_Price { get; set; }
    }
}