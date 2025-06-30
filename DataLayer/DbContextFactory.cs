using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataLayer;

public class DbContextFactory : IDesignTimeDbContextFactory<DVdDbContext>
{
    public DVdDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();
        var optionsBuilder = new DbContextOptionsBuilder<DVdDbContext>();
        var connectionString = configuration.GetConnectionString("postgres");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            Console.WriteLine("ConnectionString: " + connectionString);
        }
        optionsBuilder.UseNpgsql(connectionString);

        return new DVdDbContext(optionsBuilder.Options);
    }
}
