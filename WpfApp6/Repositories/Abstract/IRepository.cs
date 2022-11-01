using System;
using System.Collections.Generic;

namespace WpfApp6.Repositories.Abstract
{
    public interface IRepository<T>
    {
        T? Get(Func<T, bool> predicate);
        List<T>? GetList(Func<T, bool>? predicate = null);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
