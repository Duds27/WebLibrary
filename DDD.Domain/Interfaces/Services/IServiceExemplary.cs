using DDD.Domain.Arguments.Exemplary;

namespace DDD.Domain.Interfaces.Services
{
    public interface IServiceBook
    {
        AdicionarExemplarResponse Adicionar(AdicionarExemplarRequest request);
    }
}