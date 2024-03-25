using System.ComponentModel.DataAnnotations;

namespace AppliancesShop.DAL.Dtos
{
	public enum Roles
	{
        [Display(Name = "Менеджер")]
        Manager = 0,

        [Display(Name = "Администратор")]
        Admin = 1,

        [Display(Name = "Клиент")]
        Client = 2
	}
}
