using EFCoreTests.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divagando.Database.EntityConfigurations
{
    internal sealed class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(e => new { e.CreatedAt });
            builder.HasAlternateKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Name);
            builder.Property(e => e.CreatedAt);
        }
    }
}
