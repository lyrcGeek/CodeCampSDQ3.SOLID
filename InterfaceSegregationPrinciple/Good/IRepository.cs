using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Good
{
    public interface IRepository<T>
    {
        T Add(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
