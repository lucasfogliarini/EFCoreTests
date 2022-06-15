using EFCoreTests;
using EFCoreTests.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var serviceCollection = new ServiceCollection();
serviceCollection.AddDbContext<EFCoreDbContext>(options =>
{
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
    //options.UseInMemoryDatabase("efCoreDb");
    options.UseSqlServer(@"Server=NB-0067;Database=efcore;Trusted_Connection=True;");
});
var serviceProvider = serviceCollection.BuildServiceProvider();


var efCoreDbContext = serviceProvider.GetService<EFCoreDbContext>();
var account = new Account
{
    Id = 1,
    Name = "Name2",
    CreatedAt = DateTime.Now.Date
};

efCoreDbContext.Update(account);
efCoreDbContext.SaveChanges();

Console.Read();

