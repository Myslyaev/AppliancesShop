namespace AppliancesShop.DAL.Dtos
{
	public class ProductDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public int? Price { get; set; }

		public string? Description { get; set; }

		public string? Img { get; set; }

		public List<AvailabilityDto>? Availability { get; set; }
	}
}
