using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppliancesShop.DAL.Repositories
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        public AvailabilityDto AddAvailability(AvailabilityDto availability)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                context.Availability.Add(availability);
                context.SaveChanges();
            }
            return availability;
        }

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
                return context.Availability.Where(AvailabilityDto => AvailabilityDto.Shop.Id == shopId).Include(AvailabilityDto => AvailabilityDto.Shop)
                    .Include(AvailabilityDto => AvailabilityDto.Product).ToList();
            }
        }
    }
}

