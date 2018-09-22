using DDD.Domain.Entities.Base;

namespace DDD.Domain.Entities
{
    public class Exemplary : EntityBase
    {
        public Exemplary(int id) : base(id)
        {
        }

        public int Book_Id { get; set; }
        public int Exemplary_Count { get; set; }
    }
}