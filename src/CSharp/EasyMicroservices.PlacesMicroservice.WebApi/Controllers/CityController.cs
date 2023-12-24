using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.WebApi.Controllers
{
    public class CityController : MultilingualSimpleQueryServiceController<CityEntity, CreateCityRequestContract, UpdateCityRequestContract, CityContract, CityLanguageContract, long>
    {
        public CityController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
