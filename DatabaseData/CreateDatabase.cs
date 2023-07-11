using Database.BaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DiascanPraktika.DatabaseData
{
    static class CreateDatabase
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
                .AddDbContext<Context>(opt =>
                {
                    opt.UseNpgsql(Configuration.GetConnectionString("Connection"));
                })
            .AddTransient<DbInitializer>()
            ;
    }
}

