using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AutoMapper;

namespace AppliancesShop.BLL
{
	public class ProductClient
	{
		private IProductRepository _productRepository;
		private Mapper _mapper;

		public ProductClient()
		{
			_productRepository = new ProductRepository();
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new ProductMappingProfile());
				cfg.AddProfile(new ProductTypeMappingProfile());
			});
			_mapper = new Mapper(config);
		}

		public List<ProductOutputModel> GetAllProducts()
		{
			List<ProductDto> productDtos = _productRepository.GetAllProducts();
			return _mapper.Map<List<ProductOutputModel>>(productDtos);
		}
	}
}
