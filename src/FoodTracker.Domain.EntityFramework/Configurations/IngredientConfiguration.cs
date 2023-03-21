using FoodTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.EntityFramework.Configurations
{
    internal sealed class IngredientConfiguration : EntityConfigurationBase<Ingredient>
    {
        public override void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => x.Name);
        }
    }
}
