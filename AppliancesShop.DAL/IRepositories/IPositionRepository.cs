using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IPositionRepository
	{
		public List<PositionDto> GetPositionsById(int id);

		public PositionDto AddPosition(PositionDto position);
	}
}
