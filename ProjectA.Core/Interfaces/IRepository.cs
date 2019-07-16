using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectA.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T item);
        void Update(T item);
    }
}
