using System;

namespace EFCoreTests.Database.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
