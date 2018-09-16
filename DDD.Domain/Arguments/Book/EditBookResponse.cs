using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class EditBookResponse : IResponse
    {
        public int Book_id { get; set; }
        public string Message { get; set; }

        public static explicit operator EditBookResponse(Entities.Book entidade)
        {
            return new EditBookResponse() {
                Book_id = entidade.Book_Id.Id,
                Message = "Livro foi editado com sucesso!"
            };
        }
    }
}