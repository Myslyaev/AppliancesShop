using AppliancesShop.DAL.Dtos;

namespace AppliancesShop.DAL.IRepositories
{
	public interface IUserRepository
	{
		public List<UserDto> GetAllUsers();

		public UserDto GetUserById(int id);

		public UserDto GetUserByMail(string mail);

		public UserDto GetUserWithShopsByMail(string mail);

		public UserDto AddUser(UserDto person);

		public UserDto GetShopByMail(string mail);
	}
}
