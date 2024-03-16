namespace AppliancesShop.DAL.Dtos
{
	public class ProductRequestDto
	{
		public int? Id { get; set; }

		public List<ProductDto>? Products { get; set; }

		public List<RequestDto>? Requests { get; set; }
	}
}
