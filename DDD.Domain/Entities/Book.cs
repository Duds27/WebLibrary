using DDD.Domain.Entities.Base;

namespace DDD.Domain.Entities
{
    public class Book : EntityBase
    {
        public Book(int id) : base(id)
        {
        }

        public string Book_Title { get; set; }
        public string Book_Description { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publishing_Company { get; set; }
        public double Book_Price { get; set; }
    }
}