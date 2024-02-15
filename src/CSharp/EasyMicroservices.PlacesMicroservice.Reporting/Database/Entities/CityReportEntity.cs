using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.PlacesMicroservice.Schemas;

namespace EasyMicroservices.PlacesMicroservice.Reporting.Database.Entities;
public class CityReportEntity : CitySchema, IIdSchema<long>, IRecordIdSchema<long>
{
    public long Id { get; set; }
    public long RecordId { get; set; }

    public string Name { get; set; }
    public string EnglishName { get; set; }

    public long CountryId { get; set; }
    public string CountryName { get; set; }
    public string CountryEnglishName { get; set; }

    public long? ProvinceId { get; set; }
    public string ProvinceName { get; set; }
    public string ProvinceEnglishName { get; set; }
}