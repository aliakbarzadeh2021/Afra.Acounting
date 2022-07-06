using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Afra.Logger.Context;
using Afra.Repository.Implimentation;
using System.IO;

namespace Afra.Api
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("Main");


            optionsBuilder.UseSqlServer(connectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }

    public class LogContextFactory : IDesignTimeDbContextFactory<LogContext>
    {
        public LogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LogContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("LogDb");


            optionsBuilder.UseSqlServer(connectionString);

            return new LogContext(optionsBuilder.Options);
        }

    }
}
