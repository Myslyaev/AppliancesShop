using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppliancesShop.DAL.Repositories
{
    public class ShopRepository : IShopRepository
    {
        public List<ShopDto> GetAllShops()
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Shops.ToList();
            }
        }

        public int? GetShopByMail(string mail)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                var user= context.Users.Where(u => u.Mail == mail).Include(s=>s.Shop).Single();

                return user.Shop.Id;
            }
        }
    }
}
