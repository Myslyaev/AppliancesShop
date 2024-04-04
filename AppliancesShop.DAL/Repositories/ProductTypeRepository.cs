using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL.Repositories
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
