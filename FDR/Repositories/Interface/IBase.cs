using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDR.Repositories.Interface
{
    public interface IBase<T> where T : class
    {
        bool Insert(T objectEntity);

        bool Update(T objectEntity);

        IEnumerable<T> GetAll();


    }
}
