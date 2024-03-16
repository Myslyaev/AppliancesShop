namespace AppliancesShop.DAL.Dtos
{
	public class PositionDto
	{
		public int? Id { get; set; }

		public ProductDto? Product { get; set; }

		public int? Quantity { get; set; }
	}
}
