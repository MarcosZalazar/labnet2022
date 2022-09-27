using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;

namespace TP4.Logic
{
    public abstract class BaseLogic<T> : ILogic<T>
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }

        public abstract T GetOne(int id);

        public abstract List<T> GetAll();

        public abstract void Add(T newObject);

        public abstract void Delete(int id);

        public abstract void Update(T existingObject);

    }
}
