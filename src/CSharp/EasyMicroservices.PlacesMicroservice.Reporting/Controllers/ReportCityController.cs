using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Reporting.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.Reporting.Controllers;
public class ReportCityController : MultilingualReadableQueryServiceController<CityReportEntity, CityContract, CityLanguageContract, long>
{
    public ReportCityController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}