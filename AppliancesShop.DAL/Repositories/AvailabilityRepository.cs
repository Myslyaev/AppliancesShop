using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL.Repositories
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        public List<AvailabilityDto> GetAllAvailability()
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Availability.ToList();
            }
        }

        public List<AvailabilityDto> GetAvailabilityByProductId(int productId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Availability.Where(ProductDto => ProductDto.Product.Id == productId).ToList();
            }
        }

        public List<AvailabilityDto> GetAvailabilityByShopId(int shopId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Availability.Where(ShopDto => ShopDto.Shop.Id == shopId).ToList();
            }
        }
    }
}
