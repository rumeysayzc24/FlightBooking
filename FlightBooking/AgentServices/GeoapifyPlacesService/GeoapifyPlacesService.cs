using FlightBooking.Dtos.RestaurantDtos;


namespace FlightBooking.AgentServices.GeoapifyPlacesService
{
    public class GeoapifyPlacesService:IGeoapifyPlacesService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public GeoapifyPlacesService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<List<RestaurantDto>> SearchRestaurantsAsync(string query)
        {
            var apiKey = _configuration["Geoapify:ApiKey"];

            var url = "https://api.geoapify.com/v1/geocode/search" +
                      $"?text={Uri.EscapeDataString(query)}" +
                      "&lang=tr" +
                      "&filter=countrycode:tr" +
                      "&limit=5" +
                      $"&apiKey={apiKey}";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            // Burayı bir sonraki adımda deserialize edeceğiz.
            return new List<RestaurantDto>();
        }
    }
}
