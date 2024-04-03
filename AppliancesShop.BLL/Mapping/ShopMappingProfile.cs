using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class ShopMappingProfile : Profile
	{
		public ShopMappingProfile()
		{
			CreateMap<ShopDto, ShopInputModel>();

			CreateMap<ShopDto, ShopOutputModel>();

			CreateMap<ShopInputModel, ShopDto>();

			CreateMap<ShopOutputModel, ShopDto>();
		}
	}
}
