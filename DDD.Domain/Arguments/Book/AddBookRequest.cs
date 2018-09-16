using System;
using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class AddBookRequest : IRequest
    {
        public string Book_Title { get; set; }
        public string Book_Description { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publishing_Company { get; set; }
        public double Book_Price { get; set; }

        public override string ToString()
        {
            return $"{Book_Title}\n{Book_Description}\n{Book_Author}\n{Book_Publishing_Company}\n{Convert.ToString(Book_Price)}";
        }
    }
}