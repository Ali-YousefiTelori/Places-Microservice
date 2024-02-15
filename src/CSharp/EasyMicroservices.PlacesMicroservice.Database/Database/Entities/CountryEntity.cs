using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PlacesMicroservice.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.PlacesMicroservice.Database.Entities
{
    public class CountryEntity : CountrySchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public ICollection<CityEntity> Cities { get; set; }
        public ICollection<ProvinceEntity> Provinces { get; set; }
    }
}
