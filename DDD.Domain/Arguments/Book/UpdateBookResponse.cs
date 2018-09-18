using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class UpdateBookResponse : IResponse
    {
        public int Book_id { get; set; }
        public string Message { get; set; }

        public static explicit operator UpdateBookResponse(Entities.Book entidade)
        {
            return new UpdateBookResponse() {
                Book_id = entidade.Id,
                Message = "Livro foi editado com sucesso!"
            };
        }
    }
}