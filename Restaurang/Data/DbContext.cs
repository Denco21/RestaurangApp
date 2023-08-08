using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurang.Models;

namespace Restaurang.Data
{
	public class RestaurangDbContext : DbContext
	{
		public RestaurangDbContext(DbContextOptions<RestaurangDbContext> options)
		   : base(options)
		{
		}

		public DbSet<Dish> Dishes { get; set; }
		public DbSet<Booking> Bookings { get; set; }

		public DbSet<Drink> Drinks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Booking>()
				.Property(b => b.Id)
				.ValueGeneratedOnAdd();
		}

	}


}
