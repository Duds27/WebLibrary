using DDD.Domain.Entities.Base;

namespace DDD.Domain.Entities
{
    public class Exemplary : EntityBase
    {
     

        public Exemplary(int id, int book_Id, int exemplary_Count) : base(id)
        {
            Book_Id = book_Id;
            Exemplary_Count = exemplary_Count;
        }
        
        // public Exemplary(int book_Id, int exemplary_Count)
        // {
        //     Book_Id = book_Id;
        //     Exemplary_Count = exemplary_Count;
        // }

        public int Book_Id { get; private set; }
        public int Exemplary_Count { get; private set; }
    }
}