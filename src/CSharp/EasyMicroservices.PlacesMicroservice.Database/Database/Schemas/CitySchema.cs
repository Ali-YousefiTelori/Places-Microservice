﻿using EasyMicroservices.Cores.Database.Schemas;

namespace EasyMicroservices.PlacesMicroservice.Database.Schemas
{
    public class CitySchema : FullAbilitySchema
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Code { get; set; }
    }
}
