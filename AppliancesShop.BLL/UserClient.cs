using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.Enums;
using AppliancesShop.DAL.IRepositories;
using AutoMapper;

namespace AppliancesShop.BLL
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


    }
}
