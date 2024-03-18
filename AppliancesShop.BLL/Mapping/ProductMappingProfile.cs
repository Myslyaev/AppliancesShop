using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class ProductMappingProfile : Profile
	{
		public ProductMappingProfile()
		{
			CreateMap<ProductDto, ProductInputModel>();

			CreateMap<ProductDto, ProductOutputModel>();
		}
	}
}
