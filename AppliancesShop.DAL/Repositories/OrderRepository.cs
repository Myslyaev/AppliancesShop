using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppliancesShop.DAL.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		public OrderDto AddOrder(OrderDto order)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				context.Orders.Add(order);
				context.SaveChanges();
			}
			return order;
		}

		public List<OrderDto> GetAllOrders()
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Orders.ToList();
			}
		}

		public OrderDto GetOrderById(int id)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Orders.Where(OrderDto => OrderDto.Id == id).Single();
			}
		}

		public List<OrderDto> GetOrdersByClientId(int clientId)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Orders.Where(OrderDto => OrderDto.Client.Id == clientId).ToList();
			}
		}

		public List<OrderDto> GetOrdersByShopId(int shopId)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Orders.Where(OrderDto => OrderDto.Shop.Id == shopId).ToList();
			}
		}

		public List<OrderDto> GetRequest(List<AvailabilityDto> availability)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				var orders = context.Orders.Include(OrderDto => OrderDto.Positions).ToList();

				//foreach (var OrderDto in orders)
				//{

				//}
				//.Include(OrderDto => OrderDto.Positions.)
				//.Where()

				return orders;

			}
		}
	}
}
