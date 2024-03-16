using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
    public class AvailabilityInputModel
    {
        public ProductOutputModel? Product { get; set; }

        public ShopOutputModel? Shop { get; set; }

        public int? Quantity { get; set; }
    }
}
