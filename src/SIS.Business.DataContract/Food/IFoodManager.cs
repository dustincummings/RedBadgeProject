using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Food
{
    public interface IFoodManager
    {
        Task<bool> CreateFood(FoodCreateDTO dto);
    }
}
