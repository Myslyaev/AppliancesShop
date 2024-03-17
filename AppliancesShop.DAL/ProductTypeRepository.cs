using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL
{
	public class ProductTypeRepository : IProductTypeRepository
	{
		public List<ProductTypeDto> GetAllProductTypes()
		{
			using (Context context = SingletoneStorage.GetStorage().Context)
			{
				return context.ProductTypes.ToList();
			}
		}
	}
}
