﻿using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL
{
	public class ShopRepository : IShopRepository
	{
		public List<ShopDto> GetAllShops()
		{
			using (Context context = SingletoneStorage.GetStorage().Context)
			{
				return context.Shops.ToList();
			}
		}
	}
}
