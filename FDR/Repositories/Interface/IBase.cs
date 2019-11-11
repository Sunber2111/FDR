using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDR.Repositories.Interface
{
    public interface IBase<T> where T : class
    {
        bool Insert(T obj);

        bool Update(T obj);

        bool Delete(object id);

        IEnumerable<T> GetAll();

        T GetById(object id);

    }
}
