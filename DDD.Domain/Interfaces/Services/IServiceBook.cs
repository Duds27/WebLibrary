using DDD.Domain.Arguments.Book;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        AdicionarLivroResponse Adicionar(AdicionarLivroRequest request);
    }
}