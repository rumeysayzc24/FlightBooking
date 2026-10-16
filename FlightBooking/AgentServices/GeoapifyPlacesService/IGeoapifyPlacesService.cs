using FlightBooking.Dtos.RestaurantDtos;

namespace FlightBooking.AgentServices.GeoapifyPlacesService
{
    public interface IGeoapifyPlacesService
    {
        Task<List<RestaurantDto>> SearchRestaurantsAsync(string query);
    }
}
