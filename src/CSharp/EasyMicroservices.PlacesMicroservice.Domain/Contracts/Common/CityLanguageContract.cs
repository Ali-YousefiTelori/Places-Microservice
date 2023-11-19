using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class CityLanguageContract : CityBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(CityContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
    }
}
