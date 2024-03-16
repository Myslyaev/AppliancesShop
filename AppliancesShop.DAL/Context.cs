using AppliancesShop.DAL.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AppliancesShop.DAL
{
	public class Context : DbContext
	{
		public DbSet<AvailabilityDto> Availability { get; set; }

		public DbSet<OrderDto> Orders { get; set; }

		public DbSet<PositionDto> Positions { get; set; }

		public DbSet<ProductDto> Products { get; set; }

		public DbSet<ProductRequestDto> Products_Requests { get; set; }

		public DbSet<RequestDto> Requests { get; set; }

		public DbSet<ShopDto> Shops { get; set; }

		public DbSet<UserDto> Users { get; set; }

		public Context() 
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Options.connectionString);
		}
	}
}
