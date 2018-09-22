namespace DDD.Domain.Arguments
{
    public class AddBookResponse
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