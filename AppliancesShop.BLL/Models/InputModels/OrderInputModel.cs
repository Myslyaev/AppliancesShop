using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class OrderInputModel
	{
		public int? ClientId { get; set; }

		public int? ShopId { get; set; }

		public UserOutputModel? Client { get; set; }

		public List<PositionOutputModel>? Positions { get; set; }

		public ShopOutputModel? Shop { get; set; }

		public string? Date { get; set; }

		public bool? Status { get; set; }
	}
}
