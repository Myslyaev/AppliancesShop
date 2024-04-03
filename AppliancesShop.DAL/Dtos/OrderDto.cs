namespace AppliancesShop.DAL.Dtos
{
	public class OrderDto
	{
		public int? Id { get; set; }

		public int? ClientId { get; set; }

		public int? ShopId { get; set; }

		public UserDto? Client { get; set; }

		public List<PositionDto>? Positions { get; set; }

		public ShopDto? Shop { get; set; }

		public string? Date { get; set; }

		public bool? Status { get; set; }
	}
}
