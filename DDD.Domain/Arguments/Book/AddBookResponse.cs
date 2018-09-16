using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Book
{
    public class AddBookResponse : IResponse
    {
        public int Book_Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Book entidade)
        {
            return new AdicionarJogadorResponse() {
                Book_Id = entidade.Book_Id.Id,
                Message = "Livro adicionado com sucesso!"
            };
        }
    }
}