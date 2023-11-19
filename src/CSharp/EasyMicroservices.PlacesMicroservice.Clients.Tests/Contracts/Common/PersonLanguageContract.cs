﻿using Places.GeneratedServices;
using EasyMicroservices.PlacesMicroservice.Clients.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.PlacesMicroservice.Clients.Tests.Contracts.Common
{
    public class ServiceLanguageContract
    {
        public string Language { get; set; }
        public string Data { get; set; }
    }
    public class PersonLanguageContract
    {
        [ContentLanguage(nameof(PersonContract.Title))]
        public List<ServiceLanguageContract> Titles { get; set; }
        public PostContract Post { get; set; }
        public List<PostContract> Posts { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
