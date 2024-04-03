using AppliancesShop.BLL.Models.OutputModels;

namespace AppliancesShop.BLL.Models.InputModels
{
    public class PositionInputModel
    {
		public int? ProductId { get; set; }

		public int? OrderDtoId { get; set; }

		public ProductOutputModel? Product { get; set; }

        public int? Quantity { get; set; }
    }
}
