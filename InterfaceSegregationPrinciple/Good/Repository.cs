using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Good
{
    public abstract class Repository<T> : IRepository<T>
    {
        public T Add(T entity)
        {
            //Logic to Add entity
            return entity;
        }

        public void Update(T entity)
        {
            //Logic to Update entity
        }

        public T GetById(int id)
        {
            //Logic to Get entity by Id
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            //Logic to get array of Type
            throw new NotImplementedException();
        }
    }
}
