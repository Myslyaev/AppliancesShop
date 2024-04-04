using AppliancesShop.DAL.Enums;

namespace AppliancesShop.BLL.Models.OutputModels
{
	public class UserOutputModel
	{
		public int? Id { get; set; }

		public int? ShopId { get; set; }

		public string? Name { get; set; }

		public string? Surname { get; set; }

		public string? PhoneNumber { get; set; }

		public Roles? Role { get; set; }

		public string? Mail { get; set; }

		public string? Password { get; set; }

		public List<OrderOutputModel>? Orders { get; set; }

		public ShopOutputModel? Shop { get; set; }
	}
}
