using DDD.Domain.Interfaces.Arguments;

namespace DDD.Domain.Arguments.Exemplary
{
    public class GetExemplaryResponse : IResponse
    {
        public int Book_Id { get; set; }
        public int Exemplary_Count { get; set; }

        public static explicit operator GetExemplaryResponse(Entities.Exemplary entidade)
        {
            return new GetExemplaryResponse() {
                Book_Id = entidade.Book_Id.Id,
                Exemplary_Count = entidade.Exemplary_Count
            };
        }
    }
}