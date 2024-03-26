using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.DAL
{
	public class AvailabilityRepository : IAvailabilityRepository
	{
		public List<AvailabilityDto> GetAllAvailability()
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Availability.ToList();
			}
		}

		public List<AvailabilityDto> GetAvailabilityByProductId(int productId)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				return context.Availability.Where(ProductDto => ProductDto.Product.Id == productId).ToList();
			}
		}
	}
}
