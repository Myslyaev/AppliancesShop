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
                return context.Availability.Include(s=>s.Shop).Include(p=>p.Product).ToList();
            }
        }

        public List<AvailabilityDto> GetAvailabilityByProductId(int productId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Availability.Where(p => p.Product.Id == productId).Include(s => s.Shop)
                    .Include(p => p.Product).ToList();
            }
        }

        public List<AvailabilityDto> GetAvailabilityByShopId(int shopId)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Availability.Where(s => s.Shop.Id == shopId).Include(s => s.Shop)
                    .Include(p => p.Product).ToList();
            }
        }
    }
}

