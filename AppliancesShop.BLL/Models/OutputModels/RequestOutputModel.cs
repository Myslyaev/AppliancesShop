namespace AppliancesShop.BLL.Models.OutputModels
{
	public class RequestOutputModel
	{
		public int? Id { get; set; }

		public ProductOutputModel? Product { get; set; }

		public ShopOutputModel? FromShop { get; set; }

		public ShopOutputModel? ToShop { get; set; }

		public int? Quantity { get; set; }
	}
}
