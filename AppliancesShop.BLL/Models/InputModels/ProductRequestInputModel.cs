using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class ProductRequestInputModel
	{
		public List<ProductOutputModel>? Products { get; set; }

		public List<RequestOutputModel>? Requests { get; set; }
	}
}
