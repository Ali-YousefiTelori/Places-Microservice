using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.PlacesMicroservice.Database.Contexts;

namespace EasyMicroservices.PlacesMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.BuildWithUseCors<PlacesContext>(null, true);
            build.MapControllers();
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<PlacesContext>(args);
            app.Services.Builder<PlacesContext>();
            app.Services.AddTransient((serviceProvider) => new UnitOfWork(serviceProvider));
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            app.Services.AddTransient(serviceProvider => new PlacesContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));

            StartUpExtensions.AddAuthentication("RootAddresses:Authentication");
            StartUpExtensions.AddWhiteLabel("Places", "RootAddresses:WhiteLabel");
            return app;
        }
    }
}