using System;

namespace EFCoreTests.Database.Entities
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
    }
}
