using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Food;
using RedStarter.Database.Entities.Food;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Food
{
    public class FoodRepository : IFoodRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public FoodRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateFood(FoodCreateRAO rao)
        {
            var entity = _mapper.Map<FoodEntity>(rao);

           await _context.FoodTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
                


            
        }
    }
}
