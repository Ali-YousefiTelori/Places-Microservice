using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.PlacesMicroservice.Schemas
{
    public class CountrySchema : FullAbilitySchema
    {
        /// <summary>
        /// Start number of DialingCode in each country
        /// </summary>
        public string DialingCode { get; set; }
        public string ShortName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
