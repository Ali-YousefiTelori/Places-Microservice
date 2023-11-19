namespace EasyMicroservices.PlacesMicroservice.Contracts.Requests
{
    public class UpdateCountryRequestContract : CreateCountryRequestContract
    {
        public long Id { get; set; }
    }
}
