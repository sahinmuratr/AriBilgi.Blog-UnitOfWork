using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AriBilgi.Blog.Shared
{
    public interface IRepository<T> where T : class, IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T get(Func<T, bool> predicate);
        List<T> GetAll();
        List<T> GetlAll(Func<T, bool> predicate);
        bool Any(Func<T, bool> predicate);
        int Count(Func<T, bool> predicate);
    }
}
