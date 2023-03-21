using FoodTracker.Domain.Entities;
using FoodTracker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.EntityFramework.Repositories
{
    internal sealed class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(DataContext context) : base(context)
        {
        }
    }
}
