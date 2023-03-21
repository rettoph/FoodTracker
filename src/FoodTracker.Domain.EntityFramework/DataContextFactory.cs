using FoodTracker.Domain.EntityFramework.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.EntityFramework
{
    internal sealed class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);
#if DEVELOPMENT
                builder.AddJsonFile("appsettings.Development.json", optional: true);
#endif

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(p => builder.Build());
            services.RegisterFoodTrackerEntityFramework();

            var provider = services.BuildServiceProvider();
            return provider.GetRequiredService<DataContext>();
        }
    }
}
