using AppliancesShop.BLL.Clients;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class ProductTypeMappingProfile : Profile
	{
		public ProductTypeMappingProfile()
		{
			CreateMap<ProductTypeDto, ProductTypeInputModel>();

			CreateMap<ProductTypeDto, ProductTypeOutputModel>();

            CreateMap<ProductTypeInputModel, ProductTypeDto>();

			CreateMap<ProductTypeOutputModel, ProductTypeDto>();
        }
	}
}
