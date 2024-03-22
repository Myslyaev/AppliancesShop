namespace AppliancesShop.BLL.Models.OutputModels
{
    public class ProductOutputModel
    {
        public int? Id { get; set; }

        public ProductTypeOutputModel? Type { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public string? Description { get; set; }

        public string? Img { get; set; }

        public List<AvailabilityOutputModel>? Availability { get; set; }
    }
}
