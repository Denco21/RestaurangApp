using Microsoft.EntityFrameworkCore;
using Restaurang.Data;
using Restaurang.Models;


namespace Restaurang.Services.DataService
{
    public class DataService : IDataService
    {
        private readonly RestaurangDbContext _context;

        public DataService(RestaurangDbContext context)
        {
            _context = context;
        }

        public async Task<List<Dish>> GetDishes()
        {
            return await _context.Dishes.ToListAsync();
        }

        public async Task<List<Drink>> GetDrinksAsync()
        {
            return await _context.Drinks.ToListAsync();
        }

        public async Task<Dish> GetDishById(int id)
        {
            return await _context.Dishes.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<List<Booking>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }
    }
}
