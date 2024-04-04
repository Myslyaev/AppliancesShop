using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IOrderRepository
	{
		public List<OrderDto> GetAllOrders();

		public List<OrderDto> GetOrdersByShopId(int shopId);

		public List<OrderDto> GetOrdersByClientId(int clientId);

		public OrderDto GetOrderById(int id);

		public OrderDto AddOrder(OrderDto order);

		public List<OrderDto> GetRequest(List<AvailabilityDto> availability);
	}
}
