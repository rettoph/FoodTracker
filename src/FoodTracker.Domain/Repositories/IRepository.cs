using FoodTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Common.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
    }
}
