namespace DDD.Domain.Entities.Base
{
    public abstract class EntityBase
    {        
        protected EntityBase(int id)
        {
            Id = id;
        }

        // protected EntityBase()
        // {
            
        // }

        public int Id { get; private set; }
    }
}