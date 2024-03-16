using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class ProductRequestMappingProfile : Profile
	{
		public ProductRequestMappingProfile()
		{
			CreateMap<ProductRequestDto, ProductRequestInputModel>();

			CreateMap<ProductRequestDto, ProductRequestOutputModel>();
		}
	}
}
