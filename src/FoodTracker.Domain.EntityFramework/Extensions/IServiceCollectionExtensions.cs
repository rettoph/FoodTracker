using FoodTracker.Domain.EntityFramework.Repositories;
using FoodTracker.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.EntityFramework.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterFoodTrackerEntityFramework(this IServiceCollection services)
        {
            services.AddTransient<IIngredientRepository, IngredientRepository>();

            return services.AddDbContext<DataContext>((provider, options) =>
            {
                var configuration = provider.GetRequiredService<IConfiguration>();
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(DataContext).Assembly.FullName));
            });
        }
    }
}
