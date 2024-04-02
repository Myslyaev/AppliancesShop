using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
    public interface IAvailabilityRepository
    {
        public List<AvailabilityDto> GetAllAvailability();

        public List<AvailabilityDto> GetAvailabilityByProductId(int productId);

        public List<AvailabilityDto> GetAvailabilityByShopId(int shopId);

        public AvailabilityDto AddAvailability(AvailabilityDto availability);
    }
}
