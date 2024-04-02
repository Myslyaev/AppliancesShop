using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IShopRepository
	{
		public List<ShopDto> GetAllShops();

        public int? GetShopByMail(string mail);
    }
}
