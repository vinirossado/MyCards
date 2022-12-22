using System;

namespace MagicAPI.Models
{
    //public abstract class Entity<T> where T : Entity<T>
    //{

    //}
    public abstract class Entity<T, TKey> where T : Entity<T, TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedAt { get; set; }

        protected Entity()
        {

        }
    }
}
