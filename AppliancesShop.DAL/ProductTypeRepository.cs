using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;

namespace AppliancesShop.DAL
{
	public class ProductTypeRepository : IProductTypeRepository
	{
		public ProductTypeDto AddProductType(ProductTypeDto productType)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				context.ProductTypes.Add(productType);
				context.SaveChanges();
			}
			return productType;
		}

		public List<ProductTypeDto> GetAllProductTypes()
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.ProductTypes.ToList();
			}
		}
	}
}
