using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL.Repositories
{
	public class PositionRepository : IPositionRepository
	{
		public PositionDto AddPosition(PositionDto position)
		{
			Context context = SingletoneStorage.GetStorage().Context;
			{
				context.Positions.Add(position);
				context.SaveChanges();
			}
			return position;
		}

		public List<PositionDto> GetPositionsById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
