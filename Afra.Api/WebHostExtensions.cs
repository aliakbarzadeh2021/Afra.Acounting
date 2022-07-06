using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Afra.Logger.Context;
using Afra.Repository.Implimentation;

namespace Afra.Api
{
    public static class WebHostExtensions
    {
        public static IWebHost Seed(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var databaseContext = serviceProvider.GetRequiredService<DataContext>();
                var logContext = serviceProvider.GetRequiredService<LogContext>();

                databaseContext.Database.Migrate();
                logContext.Database.Migrate();
            }

            return host;
        }

    }
}
