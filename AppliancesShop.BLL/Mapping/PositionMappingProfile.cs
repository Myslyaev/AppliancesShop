using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class PositionMappingProfile : Profile
	{
		public PositionMappingProfile()
		{
			CreateMap<PositionDto, PositionInputModel>();

			CreateMap<PositionDto, PositionOutputModel>();
		}
	}
}
