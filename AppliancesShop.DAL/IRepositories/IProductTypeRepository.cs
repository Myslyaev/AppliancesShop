using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IProductTypeRepository
	{
		public List<ProductTypeDto> GetAllProductTypes();

		public ProductTypeDto AddProductType(ProductTypeDto productType);
	}
}
