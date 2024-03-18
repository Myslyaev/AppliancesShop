using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class RequestInputModel
	{
		public ProductOutputModel? Product { get; set; }

		public ShopOutputModel? FromShop { get; set; }

		public ShopOutputModel? ToShop { get; set; }

		public int? Quantity { get; set; }
	}
}
