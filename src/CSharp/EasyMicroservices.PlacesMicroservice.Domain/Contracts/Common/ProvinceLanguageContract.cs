using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class ProvinceLanguageContract : ProvinceBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(ProvinceContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
    }
}
