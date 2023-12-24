using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.WebApi.Controllers
{
    public class CountryController : MultilingualSimpleQueryServiceController<CountryEntity, CreateCountryRequestContract, UpdateCountryRequestContract, CountryContract, CountryLanguageContract, long>
    {
        public CountryController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
