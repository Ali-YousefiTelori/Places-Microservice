using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PlacesMicroservice.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Database.Entities
{
    public class ProvinceEntity : ProvinceSchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public CountryEntity Country { get; set; }
        public ICollection<CityEntity> Cities { get; set; }
    }
}
