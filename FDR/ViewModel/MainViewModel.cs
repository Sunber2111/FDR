using FDR.Repositories.Implement;
using FDR.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FDR.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private IBase<Account> repo = null;
        public MainViewModel()
        {
            repo = new BaseRepositories<Account>();

            // lấy ds :
            // var ds = repo.GetAll();
        }
    }
}
