
namespace DDD.Domain.Arguments.Book
{
    public class GetBookByTitleRequest
    {
        public string Book_Title { get; set; }

        public static explicit operator GetBookByTitleRequest(Entities.Book entidade)
        {
            return new GetBookByTitleRequest() {
                Book_Title = entidade.Book_Title
            };
        }
    }
    
}