using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;

namespace EasyMicroservices.PlacesMicroservice.WebApi.Controllers
{
    public class ProvinceController : MultilingualSimpleQueryServiceController<ProvinceEntity, CreateProvinceRequestContract, UpdateProvinceRequestContract, ProvinceContract, ProvinceLanguageContract, long>
    {
        public ProvinceController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
