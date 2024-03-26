using AppliancesShop.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IAvailabilityRepository
	{
		public List<AvailabilityDto> GetAllAvailability();

		public List<AvailabilityDto> GetAvailabilityByProductId(int productId);
	}
}
