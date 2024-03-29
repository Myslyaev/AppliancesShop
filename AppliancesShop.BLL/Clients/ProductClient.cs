using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;

namespace AppliancesShop.BLL.Clients
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
				cfg.AddProfile(new AvailabilityMappingProfile());
				cfg.AddProfile(new ShopMappingProfile());
			});
            _mapper = new Mapper(config);
        }

        public List<ProductOutputModel> GetAllProducts()
        {
            List<ProductDto> productDtos = _productRepository.GetAllProducts();
            return _mapper.Map<List<ProductOutputModel>>(productDtos);
        }

        public List<ProductOutputModel> GetProductsByProductTypeId(int productTypeId)
        {
            List<ProductDto> productDtos = _productRepository.GetProductsByProductTypeId(productTypeId);
            return _mapper.Map<List<ProductOutputModel>>(productDtos);
        }

        public ProductOutputModel AddProduct(ProductInputModel product)
        {
            ProductDto productDtos = _productRepository.AddProduct(_mapper.Map<ProductDto>(product));
            ProductOutputModel productOutput = _mapper.Map<ProductOutputModel>(productDtos);
            return productOutput;
        }

        public ProductOutputModel GetProductById(int id)
        {
            ProductDto productDtos = _productRepository.GetProductById(id);
            return _mapper.Map<ProductOutputModel>(productDtos);
        }

		public List<ProductOutputModel> GetProductAvailabilityByProductId(int productId)
		{
			List<ProductDto> productDtos = _productRepository.GetProductAvailabilityByProductId(productId);
			return _mapper.Map<List<ProductOutputModel>>(productDtos);
		}
	}
}
