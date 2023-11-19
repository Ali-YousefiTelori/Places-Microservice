namespace EasyMicroservices.PlacesMicroservice.Contracts.Requests
{
    public class UpdateCityRequestContract : CreateCityRequestContract
    {
        public long Id { get; set; }
    }
}
