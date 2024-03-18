using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class UserInputModel
	{
		public string? Name { get; set; }

		public string? Surname { get; set; }

		public string? PhoneNumber { get; set; }

		public Constants? Role { get; set; }

		public string? Mail { get; set; }

		public string? Password { get; set; }

		public List<OrderOutputModel>? Orders { get; set; }

		public ShopOutputModel? Shop { get; set; }
	}
}
