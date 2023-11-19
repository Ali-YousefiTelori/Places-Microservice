using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class CityBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Code { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }

        public long CountryId { get; set; }
        public long? ProvinceId { get; set; }
    }
}
