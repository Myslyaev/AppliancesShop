namespace AppliancesShop.DAL.Dtos
{
	public class RequestDto
	{
		public int? Id { get; set; }

		public ProductDto? Product { get; set; }

		public ShopDto? FromShop { get; set; }

		public ShopDto? ToShop { get; set; }

		public int? Quantity { get; set; }
	}
}
