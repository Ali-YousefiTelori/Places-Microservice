using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Contracts.Requests;
using EasyMicroservices.PlacesMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.PlacesMicroservice.WebApi.Controllers
{
    public class CityController : MultilingualSimpleQueryServiceController<CityEntity, CreateCityRequestContract, UpdateCityRequestContract, CityContract, CityLanguageContract, long>
    {
        public CityController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override async Task<MessageContract<long>> Add(CreateCityRequestContract request, CancellationToken cancellationToken = default)
        {
            if (request.CountryId == 0)
                request.CountryId = await UnitOfWork.GetReadableOf<ProvinceEntity>()
                    .Where(x => x.Id == request.ProvinceId)
                    .Select(x => x.CountryId)
                    .FirstOrDefaultAsync();
            return await base.Add(request, cancellationToken);
        }
    }
}
