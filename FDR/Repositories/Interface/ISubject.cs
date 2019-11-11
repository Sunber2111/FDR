using FDR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDR.Repositories.Interface
{
    public interface ISubject:IBase<MonHocModel>
    {
        bool Delete(String id);

        bool Find(String id);
    }
}
