using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class AddBookResponse : IResponse
    {
        public int Book_Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AddBookResponse(Entities.Book entidade)
        {
            return new AddBookResponse() {
                Book_Id = entidade.Id,
                Message = "Livro adicionado com sucesso!"
            };
        }
    }
}