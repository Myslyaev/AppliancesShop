using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AutoMapper;

namespace AppliancesShop.BLL
{
	public class ShopClient
	{
		private IShopRepository _shopRepository;
		private Mapper _mapper;

		public ShopClient()
		{
			_shopRepository = new ShopRepository();
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new ShopMappingProfile());
			});
			_mapper = new Mapper(config);
		}

		public List<ShopOutputModel> GetAllShops()
		{
			List<ShopDto> shopDtos = _shopRepository.GetAllShops();
			return _mapper.Map<List<ShopOutputModel>>(shopDtos);
		}
	}
}
