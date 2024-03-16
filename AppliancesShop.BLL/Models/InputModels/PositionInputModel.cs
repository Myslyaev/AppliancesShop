using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
    public class PositionInputModel
    {
        public ProductOutputModel? Product { get; set; }

        public int? Quantity { get; set; }
    }
}
