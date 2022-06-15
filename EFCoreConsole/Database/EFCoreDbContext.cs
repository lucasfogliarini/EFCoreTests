using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCoreTests
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(thisAssembly);
        }

    }
}
