using Contents.GeneratedServices;
using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class CountryLanguageContract : CountryBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(CountryContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
    }
}
