using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Cores.Widgets;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Builders;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.Reporting.Widgets;

public class PlacesReportingWidgetBuilder : IWidgetBuilder
{
    public void Build(IWidgetManager widgetManager)
    {
        widgetManager.Register(new SimpleReportingEntityWidget<CityEntity, CityReportEntity, CreateCityRequestContract>());
        widgetManager.Register(new PlacesReportModuleDatabaseBuilder());
    }
}
