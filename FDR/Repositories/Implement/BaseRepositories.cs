using FDR.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDR.Repositories.Implement
{
    public class BaseRepositories<T> : IBase<T> where T : class
    {
        public BaseRepositories()
        {
            using (var db = new DbEntities())
            {
                table = db.Set<T>();
            }
        }
        private DbSet<T> table = null;

        public bool Delete(object id)
        {
            try
            {
                T obj = table.Find(id);
                table.Remove(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public bool Insert(T obj)
        {
            try
            {
                table.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T obj)
        {
            try
            {
               using(var db = new DbEntities())
               {
                    table.Attach(obj);
                    db.Entry(obj).State = EntityState.Modified;
               }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
