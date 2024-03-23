using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class UserMappingProfile : Profile
	{
		public UserMappingProfile()
		{
			CreateMap<UserDto, UserInputModel>();

			CreateMap<UserDto, UserOutputModel>();

			CreateMap<UserInputModel, UserDto>();
		}
	}
}
