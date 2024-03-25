using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required(ErrorMessage = "Введите значение в поле")]
        public string Password { get; set; }
    }
}
