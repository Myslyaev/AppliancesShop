using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.Enums;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Net.Http;
using System.Security.Claims;

namespace AppliancesShop.BLL.Clients
{
    public class UserClient
    {
        private IUserRepository _userRepository;
        private Mapper _mapper;

        public UserClient()
        {
            _userRepository = new UserRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserMappingProfile());
                cfg.AddProfile(new ShopMappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public UserOutputModel RegisterClient(UserRegistrationInputModel client)
        {
            UserDto userDtoInput = _mapper.Map<UserDto>(client);
            userDtoInput.Role = Roles.Client;
            UserDto userDtoOutput = _userRepository.AddUser(_mapper.Map<UserDto>(userDtoInput));
            UserOutputModel clientOutput = _mapper.Map<UserOutputModel>(userDtoOutput);

            return clientOutput;
        }

        public List<UserOutputModel> GetAllUsers()
        {
            List<UserDto> userDtos = _userRepository.GetAllUsers();

            return _mapper.Map<List<UserOutputModel>>(userDtos);
        }

        public UserOutputModel GetUserById(int id)
        {
            UserDto userDto = _userRepository.GetUserById(id);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public UserAutenthicationInputModel GetUserByMail(string mail)
        {
            UserDto userDto = _userRepository.GetUserByMail(mail);
            UserAutenthicationInputModel user = _mapper.Map<UserAutenthicationInputModel>(userDto);

            return user;
        }

        public UserOutputModel GetShopByMail(string mail)
        {
            UserDto userDto = _userRepository.GetShopByMail(mail);
            UserOutputModel user = _mapper.Map<UserOutputModel>(userDto);

            return user;
        }

        public (bool, ClaimsPrincipal) GetClaims (UserAutenthicationInputModel user, string password)
        {
            bool isAuthenticated = false;
            ClaimsPrincipal pr = null;

            if (user.Password == password && user.Role == Roles.Admin)
            {
                var claims = new List<Claim>()
                {
                    new Claim("Mail", user.Mail),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                pr = new ClaimsPrincipal(identity);

                isAuthenticated = true;
            }

            if (user.Password == password && user.Role == Roles.Manager)
            {
                var claims = new List<Claim>()
                {
                    new Claim("Mail", user.Mail),
                    new Claim(ClaimTypes.Role, "Manager")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                pr = new ClaimsPrincipal(identity);

                isAuthenticated = true;
            }

            if (user.Password == password && user.Role == Roles.Client)
            {
                var claims = new List<Claim>()
                {
                    new Claim("Mail", user.Mail),
                    new Claim(ClaimTypes.Role, "Client")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                pr = new ClaimsPrincipal(identity);

                isAuthenticated = true;
            }

            return (isAuthenticated, pr);
        }
    }
}
