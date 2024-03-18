namespace AppliancesShop.BLL.Models.OutputModels
{
	public class ProductRequestOutputModel
	{
		public int? Id { get; set; }

		public List<ProductOutputModel>? Products { get; set; }

		public List<RequestOutputModel>? Requests { get; set; }
	}
}
