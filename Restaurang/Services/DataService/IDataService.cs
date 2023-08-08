using Restaurang.Models;

namespace Restaurang.Services.DataService
{
	public interface IDataService
	{
		Task<List<Dish>> GetDishes();
        Task<List<Drink>> GetDrinksAsync();
        Task<Dish> GetDishById(int id);
		Task<List<Booking>> GetBookings();
		Task CreateBooking(Booking booking);
	}
}
