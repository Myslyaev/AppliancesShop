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
                return context.Products.Where(ProductDto => ProductDto.Type.Id == productTypeId).ToList();
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
                return context.Products.Where(ProductDto => ProductDto.Id == id).Single();
            }
        }

        public List<ProductDto> GetProductAvailabilityByProductId(int productId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Products.Where(ProductDto => ProductDto.Id == productId).Include(ProductDto => ProductDto.Availability)
                    .ThenInclude(AvailabilityDto => AvailabilityDto.Shop).ToList();
            }

        }
    }
}
