using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Requests
{
    public class CreateProvinceRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage(nameof(CityContract.Name))]
        public List<LanguageDataContract> Names { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string UniqueIdentity { get; set; }
    }
}
