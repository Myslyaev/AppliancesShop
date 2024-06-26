﻿namespace AppliancesShop.BLL.Models.OutputModels
{
    public class AvailabilityOutputModel
    {
        public int? Id { get; set; }

		public int? ProductId { get; set; }

		public int? ShopId { get; set; }

		public ProductOutputModel? Product { get; set; }

        public ShopOutputModel? Shop { get; set; }

        public int? Quantity { get; set; }
    }
}

