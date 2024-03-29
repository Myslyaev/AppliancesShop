using System.ComponentModel.DataAnnotations;

namespace AppliancesShop.BLL.Models.InputModels
{
	public class UserRegistrationInputModel
	{
		[Required(ErrorMessage = "Введите фамилию")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Введите имя")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Введите почту")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Введите номер телефона")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Введите пароль")]
		public string Password { get; set; }
	}
}
