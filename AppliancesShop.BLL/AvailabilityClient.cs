﻿using AppliancesShop.BLL.Mapping;
using AppliancesShop.BLL.Models.OutputModels;
using AppliancesShop.DAL;
using AppliancesShop.DAL.Dtos;
using AppliancesShop.DAL.IRepositories;
using AutoMapper;

namespace AppliancesShop.BLL
{
	public class AvailabilityClient
	{
		private IAvailabilityRepository _availabilityRepository;
		private Mapper _mapper;

		public AvailabilityClient()
		{
			_availabilityRepository = new AvailabilityRepository();
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new AvailabilityMappingProfile());
			});
			_mapper = new Mapper(config);
		}

		public List<AvailabilityOutputModel> GetAllAvailability()
		{
			List<AvailabilityDto> availabilityDtos = _availabilityRepository.GetAllAvailability();
			return _mapper.Map<List<AvailabilityOutputModel>>(availabilityDtos);
		}

		public List<AvailabilityOutputModel> GetAvailabilityByProductId(int productId)
		{
			List<AvailabilityDto> availabilityDtos = _availabilityRepository.GetAvailabilityByProductId(productId);
			return _mapper.Map<List<AvailabilityOutputModel>>(availabilityDtos);
		}
	}
}
