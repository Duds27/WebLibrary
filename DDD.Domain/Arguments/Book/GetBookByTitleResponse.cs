namespace DDD.Domain.Arguments.Book
{
    public class GetBookByTitleResponse
    {
        public int Id { get; set; }
        public string Book_Title { get; set; }
        public string Book_Description { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publishing_Company { get; set; }
        public double Book_Price { get; set; }

        public static explicit operator GetBookByTitleResponse(Entities.Book entidade)
        {
            return new GetBookByTitleResponse() {
                Id = entidade.Id,
                Book_Title = entidade.Book_Title,
                Book_Description = entidade.Book_Description,
                Book_Author = entidade.Book_Author,
                Book_Publishing_Company = entidade.Book_Publishing_Company,
                Book_Price = entidade.Book_Price
            };
        } 
    }
}