using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Database.Widgets;
using EasyMicroservices.Cores.Widgets;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Builders;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.Reporting.Widgets;

public class PlacesReportingWidgetBuilder : ReportingBuilderWidget
{
    readonly IDatabaseWidgetManager _widgetManager;
    public PlacesReportingWidgetBuilder(IDatabaseWidgetManager widgetManager)
    {
        _widgetManager = widgetManager;
    }

    public override void Build()
    {
        _widgetManager.Register(new SimpleReportingEntityWidget<CityEntity, CityReportEntity, CreateCityRequestContract>());
        _widgetManager.Register(new PlacesReportModuleDatabaseBuilder());
    }
}
