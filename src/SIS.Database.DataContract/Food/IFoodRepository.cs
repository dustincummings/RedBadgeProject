using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Food
{
    public interface IFoodRepository
    {
        Task<bool> CreateFood(FoodCreateRAO rao);
        Task<IEnumerable<FoodGetListItemsRAO>> GetFoods();
        Task<FoodGetListItemsRAO> GetFoodById(int id);
        Task<bool> EditFood(FoodUpdateRAO rao);


    }
}
