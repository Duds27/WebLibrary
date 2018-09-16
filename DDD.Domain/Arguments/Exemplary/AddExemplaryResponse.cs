using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class AddExemplaryResponse : IResponse
    {
        public int Exemplary_Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AddExemplaryResponse(Entities.Exemplary entidade)
        {
            return new AddExemplaryResponse() {
                Exemplary_Id = entidade.Exemplary_Id.Id,
                Message = "Exemplar adicionado com sucesso!"
            };
        }
    }
}