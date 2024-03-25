﻿using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;

namespace AppliancesShop.DAL
{
    public class UserRepository : IUserRepository
    {
        public UserDto AddUser(UserDto person)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                context.Users.Add(person);
                context.SaveChanges();
            }
            return person;
        }

        public List<UserDto> GetAllUsers()
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Users.ToList();
            }
        }

        public List<ProductDto> GetAllProducts()
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Products.ToList();
            }
        }

        public UserDto GetUserById(int id)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Users.Where(u => u.Id == id).Single();
            }
        }

        public UserDto GetUserByMail(string mail)
        {
            Context context = SingletoneStorage.GetStorage().Context;
            {
                return context.Users.Where(u => u.Mail == mail).Single();
            }
        }
    }
}
