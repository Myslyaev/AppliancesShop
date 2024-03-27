using AppliancesShop.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IOrderRepository
	{
		public List<OrderDto> GetAllOrders();

		public List<OrderDto> GetOrdersByShopId(int shopId);

		public List<OrderDto> GetOrdersByClientId(int clientId);

		public OrderDto GetOrderById(int id);

		public OrderDto AddOrder(OrderDto order);
	}
}
