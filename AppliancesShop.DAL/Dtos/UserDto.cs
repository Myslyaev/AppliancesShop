using AppliancesShop.DAL.Enums;

namespace AppliancesShop.DAL.Dtos
{
    public class UserDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public string? Surname { get; set; }

		public string? PhoneNumber { get; set; }

		public Roles? Role { get; set; }

		public string Mail { get; set; }

		public string Password { get; set; }

		public List<OrderDto>? Orders { get; set; }

		public ShopDto? Shop { get; set; }
	}

}
