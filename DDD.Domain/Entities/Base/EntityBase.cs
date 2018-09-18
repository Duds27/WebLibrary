using System;

namespace DDD.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            Id = Convert.ToInt32(Guid.NewGuid());
        }

        public int Id { get; private set; }
    }
}