using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PlacesMicroservice.Database.Schemas;

namespace EasyMicroservices.PlacesMicroservice.Database.Entities
{
    public class CityEntity : CitySchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public long CountryId { get; set; }
        public CountryEntity Country { get; set; }
        public long? ProvinceId { get; set; }

        public ProvinceEntity Province { get; set; }
    }
}
