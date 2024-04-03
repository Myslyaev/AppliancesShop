using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
    public class ProductInputModel
    {
        public int Id { get; set; }

		public int? TypeId { get; set; }

		public ProductTypeOutputModel? Type { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public string? Description { get; set; }

        public string? Img { get; set; }

        public List<AvailabilityOutputModel>? Availability { get; set; }
    }
}
