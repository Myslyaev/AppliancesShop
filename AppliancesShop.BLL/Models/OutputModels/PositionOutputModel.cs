namespace AppliancesShop.BLL.Models.OutputModels
{
    public class PositionOutputModel
    {
        public int? Id { get; set; }

        public ProductOutputModel? Product { get; set; }

        public int? Quantity { get; set; }
    }
}
