using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.PlacesMicroservice.Database.Schemas
{
    public class ProvinceSchema : FullAbilitySchema
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
