using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL
{
	public class ProductRepository : IProductRepository
	{
		public List<ProductDto> GetAllProducts()
		{
			using (Context context = SingletoneStorage.GetStorage().Context)
			{
				return context.Products.ToList();
			}
		}
	}
}
