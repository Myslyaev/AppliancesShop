using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL
{
	public class ProductRepository : IProductRepository
	{
		public List<ProductDto> GetAllProducts()
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Products.ToList();
			}
		}

        public List<ProductDto> GetProductsByProductTypeId(int productTypeId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Products.Where(ProductDto=>ProductDto.Type.Id== productTypeId).ToList();
            }
        }

        public ProductDto AddProduct(ProductDto product)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            return product;
        }

    }
}
