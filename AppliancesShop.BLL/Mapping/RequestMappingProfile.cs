using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class RequestMappingProfile : Profile
	{
		public RequestMappingProfile()
		{
			CreateMap<RequestDto, RequestInputModel>();

			CreateMap<RequestDto, RequestOutputModel>();
		}
	}
}
