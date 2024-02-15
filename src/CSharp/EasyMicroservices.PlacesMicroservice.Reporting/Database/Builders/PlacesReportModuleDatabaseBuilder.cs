using EasyMicroservices.Cores.Database.Widgets;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.PlacesMicroservice.Reporting.Database.Builders;
public class PlacesReportModuleDatabaseBuilder : DatabaseBuilderWidget<ModelBuilder>
{
    public override void OnModelCreating(ModelBuilder modelBuilder, string suffix = "", string prefix = "")
    {
        modelBuilder.Entity<CityReportEntity>(model =>
        {
            model.ToTable(GetTableName("ReportCities", suffix, prefix));
        });
    }

    string GetTableName(string name, string suffix = "", string prefix = "")
    {
        return string.Concat(suffix, name, prefix);
    }
}
