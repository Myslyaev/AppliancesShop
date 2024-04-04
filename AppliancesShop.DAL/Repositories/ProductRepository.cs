using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppliancesShop.DAL.Repositories
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
                return context.Products.Where(p => p.Type.Id == productTypeId).ToList();
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

        public ProductDto GetProductById(int id)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Products.Where(p => p.Id == id).Single();
            }
        }

        public List<ProductDto> GetProductAvailabilityByProductId(int productId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Products.Where(p => p.Id == productId).Include(a => a.Availability)
                    .ThenInclude(s => s.Shop).ToList();
            }
        }
    }
}
