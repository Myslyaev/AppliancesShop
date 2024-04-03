namespace AppliancesShop.DAL.Dtos
{
	public class AvailabilityDto
	{
		public int? Id { get; set; }

		public int? ProductId { get; set; }

		public int? ShopId { get; set; }

		public ProductDto? Product { get; set; }

		public ShopDto? Shop { get; set; }

		public int? Quantity { get; set; }
	}
}
