using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;

namespace AppliancesShop.BLL.Clients
{
    public class ProductTypeClient
    {
        private IProductTypeRepository _productTypeRepository;
        private Mapper _mapper;

        public ProductTypeClient()
        {
            _productTypeRepository = new ProductTypeRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductTypeMappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public List<ProductTypeOutputModel> GetAllProductTypes()
        {
            List<ProductTypeDto> productTypeDtos = _productTypeRepository.GetAllProductTypes();

            return _mapper.Map<List<ProductTypeOutputModel>>(productTypeDtos);
        }

        public ProductTypeOutputModel AddProductType(ProductTypeInputModel productType)
        {
            ProductTypeDto productTypeDtos = _productTypeRepository.AddProductType(_mapper.Map<ProductTypeDto>(productType));
            ProductTypeOutputModel productTypeOutput = _mapper.Map<ProductTypeOutputModel>(productTypeDtos);

            return productTypeOutput;
        }
    }
}
