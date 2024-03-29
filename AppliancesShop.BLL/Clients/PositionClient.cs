using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.InputModels;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AppliancesShop.DAL.Repositories;
using AutoMapper;

namespace AppliancesShop.BLL.Clients
{
    public class PositionClient
    {
        private IPositionRepository _positionRepository;
        private Mapper _mapper;

        public PositionClient()
        {
            _positionRepository = new PositionRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PositionMappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public PositionOutputModel AddPosition(PositionInputModel position)
        {
            PositionDto positionDtos = _positionRepository.AddPosition(_mapper.Map<PositionDto>(position));
            PositionOutputModel positionOutput = _mapper.Map<PositionOutputModel>(positionDtos);
            return positionOutput;
        }
    }
}
