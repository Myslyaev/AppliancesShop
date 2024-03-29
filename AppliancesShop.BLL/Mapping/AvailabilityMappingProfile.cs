using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class AvailabilityMappingProfile : Profile
	{
		public AvailabilityMappingProfile()
		{
			CreateMap<AvailabilityDto, AvailabilityInputModel>();

			CreateMap<AvailabilityDto, AvailabilityOutputModel>();

			CreateMap<AvailabilityInputModel, AvailabilityDto>();
		}
	}
}
