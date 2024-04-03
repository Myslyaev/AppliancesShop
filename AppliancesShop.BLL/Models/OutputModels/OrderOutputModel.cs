namespace AppliancesShop.BLL.Models.OutputModels
{
	public class OrderOutputModel
	{
		public int? Id { get; set; }

		public int? ClientId { get; set; }

		public int? ShopId { get; set; }

		public UserOutputModel? Client { get; set; }

		public List<PositionOutputModel>? Positions { get; set; }

		public ShopOutputModel? Shop { get; set; }

		public string? Date { get; set; }

		public bool? Status { get; set; }
	}
}
