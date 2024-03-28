using AppliancesShop.DAL.Enums;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class UserAutenthicationInputModel
	{
		public string Mail { get; set; }

		public string Password { get; set; }

		public Roles? Role { get; set; }
	}
}
