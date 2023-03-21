using FoodTracker.Common.Repositories;
using FoodTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.Repositories
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
    }
}
