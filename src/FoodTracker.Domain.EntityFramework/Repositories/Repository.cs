using FoodTracker.Common.Repositories;
using FoodTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Domain.EntityFramework.Repositories
{
    internal abstract class Repository<T> : IRepository<T>
        where T : Entity
    {
        protected readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public virtual T GetById(int id)
        {
            return this.context.Set<T>().Find(id) ?? throw new KeyNotFoundException();
        }

        public virtual void Add(T item)
        {
            this.context.Set<T>().Add(item);
        }

        public virtual void Remove(T item)
        {
            this.context.Set<T>().Remove(item);
        }
    }
}
