using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AutoMapper;

namespace AppliancesShop.BLL
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
	}
}
