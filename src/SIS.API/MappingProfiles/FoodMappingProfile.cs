using AutoMapper;
using RedStarter.API.DataContract.Food;
using RedStarter.Business.DataContract.Food;
using RedStarter.Database.DataContract.Food;
using RedStarter.Database.Entities.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class FoodMappingProfile : Profile
    {
        public FoodMappingProfile()
        {
            CreateMap<FoodCreateRequest, FoodCreateDTO>();
            CreateMap<FoodCreateDTO, FoodCreateRAO>();
            CreateMap<FoodCreateRAO, FoodEntity>();

        }
    }
}
