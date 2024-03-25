using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IProductRepository
	{
		public List<ProductDto> GetAllProducts();

		public List<ProductDto> GetProductsByProductTypeId(int productTypeId);

        public ProductDto AddProduct(ProductDto product);
    }
}
