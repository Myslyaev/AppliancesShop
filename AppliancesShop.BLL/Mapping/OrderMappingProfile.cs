using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AutoMapper;

namespace AppliancesShop.BLL.Mapping
{
	public class OrderMappingProfile : Profile
	{
		public OrderMappingProfile()
		{
			CreateMap<OrderDto, OrderInputModel>();

			CreateMap<OrderDto, OrderOutputModel>();

			CreateMap<OrderInputModel, OrderDto>();
		}
	}
}
