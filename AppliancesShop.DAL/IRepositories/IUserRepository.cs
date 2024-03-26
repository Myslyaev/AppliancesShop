using AppliancesShop.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliancesShop.DAL.IRepositories
{
    public interface IUserRepository
    {
        public List<UserDto> GetAllUsers();

        public UserDto GetUserById(int id);

        public UserDto GetUserByMail(string mail);

        public UserDto AddUser(UserDto person);
    }
}
