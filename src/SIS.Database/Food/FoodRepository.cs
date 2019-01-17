using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Food;
using RedStarter.Database.Entities.Food;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<FoodGetListItemsRAO> GetFoodById(int id)
        {
            var query = await _context.FoodTableAccess.SingleAsync(e => e.FoodID == id);
            var rao = _mapper.Map<FoodGetListItemsRAO> (query);

            return rao;
        }

        public async Task<IEnumerable<FoodGetListItemsRAO>> GetFoods(int id)
        {
            var query = await _context.FoodTableAccess.Where(e => e.OwnerID == id).ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<FoodGetListItemsRAO>>(query);

            return rao;
        }
        public async Task<bool> EditFood(FoodUpdateRAO rao)
        {
            var entity = _mapper.Map<FoodEntity>(rao);
           
            _context.FoodTableAccess.Update(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteFood(int id)
        {
            var entity = await _context.FoodTableAccess.SingleAsync(e => e.FoodID == id);
            _context.FoodTableAccess.Remove(entity);

            return await _context.SaveChangesAsync() == 1;


        }
    }
}
