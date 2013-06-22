using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSustitutionPrinciple.Bad
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
