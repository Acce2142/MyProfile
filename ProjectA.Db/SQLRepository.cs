using ProjectA.Core.Interfaces;
using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectA.Db
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        public System.Linq.IQueryable<T> Collection()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public T Find(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
