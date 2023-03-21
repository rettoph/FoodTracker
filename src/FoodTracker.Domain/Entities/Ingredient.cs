using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.Entities
{
    public class Ingredient : Entity
    {
        public string Name { get; set; } = string.Empty;
    }
}
