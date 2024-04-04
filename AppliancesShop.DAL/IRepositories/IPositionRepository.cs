using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IPositionRepository
	{
		public PositionDto AddPosition(PositionDto position);
	}
}
