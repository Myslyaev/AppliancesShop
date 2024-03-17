using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IProductRepository
	{
		public List<ProductDto> GetAllProducts();
	}
}
