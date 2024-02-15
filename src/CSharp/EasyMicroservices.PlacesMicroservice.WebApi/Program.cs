using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Database.Logics;
using EasyMicroservices.Cores.Database.Widgets;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.PlacesMicroservice.Database.Contexts;
using EasyMicroservices.PlacesMicroservice.Reporting.Widgets;
using Microsoft.Extensions.Hosting;

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
            app.Services.Builder<PlacesContext>("Places")
                .UseDefaultSwaggerOptions();
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            app.Services.AddTransient(serviceProvider => new PlacesContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            app.Services.AddSingleton<ReportingBuilderWidget, PlacesReportingWidgetBuilder>();
            
            return app;
        }
    }
}