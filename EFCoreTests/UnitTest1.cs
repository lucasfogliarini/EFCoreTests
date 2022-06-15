using EFCoreTests.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace EFCoreTests
{
    public class UnitTest1
    {
        readonly IServiceProvider serviceProvider;
        public UnitTest1()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<EFCoreDbContext>(options => options.UseInMemoryDatabase("efCoreDb"));
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        [Fact]
        public void Test1()
        {
            //arrange
            var efCoreDbContext = serviceProvider.GetService<EFCoreDbContext>();
            var account = new Account
            {
                Id = 1,
                Name = "Name1"
            };

            //act
            efCoreDbContext.Update(account);
            efCoreDbContext.SaveChanges();

            //assert

        }
    }
}