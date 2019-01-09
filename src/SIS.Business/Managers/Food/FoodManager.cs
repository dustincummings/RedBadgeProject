using AutoMapper;
using RedStarter.Business.DataContract.Food;
using RedStarter.Database.DataContract.Food;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Food
{
    public class FoodManager : IFoodManager
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;

        public FoodManager(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }

        public async Task<bool> CreateFood(FoodCreateDTO dto)
        {
            var rao = _mapper.Map<FoodCreateRAO>(dto);
            if (await _repository.CreateFood(rao))
                return true;


            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FoodGetListItemsDTO>> GetFoods()
        {
            var rao = await _repository.GetFoods();
            var dto = _mapper.Map<IEnumerable<FoodGetListItemsDTO>>(rao);

            return dto;
        }

        public async Task<FoodGetListItemsDTO> GetFoodById(int id)
        {
            var rao = await _repository.GetFoodById(id);
            var dto = _mapper.Map<FoodGetListItemsDTO>(rao);

            return dto;
        }
        public async Task<bool> EditFood(FoodUpdateDTO dto)
        {
            var rao = _mapper.Map<FoodUpdateRAO>(dto);
            if (await _repository.EditFood(rao))
                return true;
            throw new NotImplementedException();


        }
    }
}
