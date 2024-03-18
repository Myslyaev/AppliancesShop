using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;

namespace AppliancesShop.DAL
{
	public class ProductTypeRepository : IProductTypeRepository
	{
		public void AddProductType(ProductTypeDto productType)
		{
			//using (Context context = SingletoneStorage.GetStorage().Context)
			//{
			//	context.ProductTypes.Add(new ProductTypeDto() {productType.Name, productType.Img });
			//	context.SaveChanges();
			//}
		}

		public List<ProductTypeDto> GetAllProductTypes()
		{
			using (Context context = SingletoneStorage.GetStorage().Context)
			{
				return context.ProductTypes.ToList();
			}
		}
	}
}
