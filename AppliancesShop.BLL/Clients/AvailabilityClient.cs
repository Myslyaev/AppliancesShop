using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;

namespace AppliancesShop.BLL.Clients
{
    public class AvailabilityClient
    {
        private IAvailabilityRepository _availabilityRepository;
        private Mapper _mapper;
        public AvailabilityClient()
        {
            _availabilityRepository = new AvailabilityRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AvailabilityMappingProfile());
				cfg.AddProfile(new ShopMappingProfile());
				cfg.AddProfile(new ProductMappingProfile());
				cfg.AddProfile(new ProductTypeMappingProfile());

			});
            _mapper = new Mapper(config);
        }

        public List<AvailabilityOutputModel> GetAllAvailability()
        {
            List<AvailabilityDto> availabilityDtos = _availabilityRepository.GetAllAvailability();
            return _mapper.Map<List<AvailabilityOutputModel>>(availabilityDtos);
        }

        public List<AvailabilityOutputModel> GetAvailabilityByProductId(int productId)
        {
            List<AvailabilityDto> availabilityDtos = _availabilityRepository.GetAvailabilityByProductId(productId);
            return _mapper.Map<List<AvailabilityOutputModel>>(availabilityDtos);
        }

        public List<AvailabilityOutputModel> GetAvailabilityByShopId(int shopId)
        {
            List<AvailabilityDto> availabilityDtos = _availabilityRepository.GetAvailabilityByShopId(shopId);
            return _mapper.Map<List<AvailabilityOutputModel>>(availabilityDtos);
        }

		public AvailabilityOutputModel AddAvailability(AvailabilityInputModel availability)
		{
			AvailabilityDto availabilityDtos = _availabilityRepository.AddAvailability(_mapper.Map<AvailabilityDto>(availability));
			AvailabilityOutputModel availabilityOutput = _mapper.Map<AvailabilityOutputModel>(availabilityDtos);
			return availabilityOutput;
		}
	}
}
