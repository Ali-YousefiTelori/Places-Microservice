using EasyMicroservices.ContentsMicroservice.Clients.Attributes;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class CountryContract : CountryBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string Name { get; set; }
    }
}

