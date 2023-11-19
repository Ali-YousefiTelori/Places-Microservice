using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.PlacesMicroservice.Contracts.Common
{
    public class CountryBaseContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        /// <summary>
        /// Start number of DialingCode in each country
        /// </summary>
        public string DialingCode { get; set; }
        public string ShortName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}