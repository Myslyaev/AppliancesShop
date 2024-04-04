using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;

namespace AppliancesShop.BLL.Clients
{
	public class OrderClient
	{
		private IOrderRepository _orderRepository;
		private Mapper _mapper;

		public OrderClient()
		{
			_orderRepository = new OrderRepository();
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new OrderMappingProfile());
				cfg.AddProfile(new ProductTypeMappingProfile());
			});
			_mapper = new Mapper(config);
		}

		public List<OrderOutputModel> GetAllOrders()
		{
			List<OrderDto> orderDtos = _orderRepository.GetAllOrders();
			return _mapper.Map<List<OrderOutputModel>>(orderDtos);
		}

		public List<OrderOutputModel> GetOrdersByClientId(int clientId)
		{
			List<OrderDto> orderDtos = _orderRepository.GetOrdersByClientId(clientId);
			return _mapper.Map<List<OrderOutputModel>>(orderDtos);
		}

		public List<OrderOutputModel> GetOrdersByShopId(int shopId)
		{
			List<OrderDto> orderDtos = _orderRepository.GetOrdersByShopId(shopId);
			return _mapper.Map<List<OrderOutputModel>>(orderDtos);
		}

		public OrderOutputModel AddOrder(OrderInputModel order)
		{
			OrderDto orderDtos = _orderRepository.AddOrder(_mapper.Map<OrderDto>(order));
			OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtos);
			return orderOutput;
		}

		public OrderOutputModel GetOrderById(int id)
		{
			OrderDto orderDtos = _orderRepository.GetOrderById(id);
			return _mapper.Map<OrderOutputModel>(orderDtos);
		}
	}
}
