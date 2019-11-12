using FDR.Repositories.Implement;
using FDR.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FDR.ViewModel
{
    public class SubjectViewModel:BaseViewModel
    {
        private ObservableCollection<MonHoc> _listSubject;

        public ObservableCollection<MonHoc> ListSubject
        {
            get => _listSubject;
            set
            {
                if(value!=null)
                {
                    _listSubject = value;
                    OnPropertyChanged("ListSubject");
                }
            }
        }

        private MonHoc _selectedSub;

        public MonHoc SelectedSub
        {
            get => _selectedSub;
            set
            {
                if (value != null)
                {
                    _selectedSub = value;
                    OnPropertyChanged("SelectedSub");

                    MaMonHoc = _selectedSub.MaMonHoc;
                    SoTinChi = _selectedSub.SoTinChi.ToString();
                    TenMonHoc = _selectedSub.TenMonHoc;
                }
            }
        }

        public ObservableCollection<string> ListKey
        {
            get => _listKey;
            set
            {
                if(value!=null)
                {
                    _listKey = value;
                    OnPropertyChanged("ListKey");
                }
            }

        }

        private ObservableCollection<string> _listKey;

        private string _selectedKey;

        public string SelectedKey
        {
            get => _selectedKey;
            set
            {
                if(value!=null)
                {
                    _selectedKey = value;
                    OnPropertyChanged("SelectedKey");
                }
            }
        }

        private IBase<MonHoc> _repoMH = null;

        private IBase<HocPhan> _repoHP = null;

        private string _keySub;

        public string KeySub
        {
            get => _keySub;
            set
            {
                if(value!=null)
                {
                    _keySub = value;
                    OnPropertyChanged("KeySub");

                    if(SelectedKey!=null)
                    {
                        if (SelectedKey.Equals("Mã Môn Học"))
                            ListSubject = new ObservableCollection<MonHoc>(_repoMH.GetMany(t => t.MaMonHoc.Contains(_keySub)));
                        else
                            ListSubject = new ObservableCollection<MonHoc>(_repoMH.GetMany(t => t.TenMonHoc.Contains(_keySub)));
                    }
                }
            }
        }

        public string MaMonHoc
        {
            get => _maMonHoc;
            set
            {
                if(value!=null)
                {
                    _maMonHoc = value;
                    OnPropertyChanged("MaMonHoc");
                }
            }
        }

        public string SoTinChi
        {
            get => _soTinChi;
            set
            {
                if (value != null)
                {
                    _soTinChi = value;
                    OnPropertyChanged("SoTinChi");
                }
            }
        }

        public string TenMonHoc
        {
            get => _tenMonHoc;
            set
            {
               if(value!=null)
                {
                    _tenMonHoc = value;
                    OnPropertyChanged("TenMonHoc");
                }
            }
        }

        private string _maMonHoc, _soTinChi, _tenMonHoc;

        public ICommand RefeshData1 { get; set; }
        public ICommand ThemMonHoc { get; set; }


        public SubjectViewModel()
        {
            _repoMH = new BaseRepositories<MonHoc>();

            _repoHP = new BaseRepositories<HocPhan>();

            CreateData();
        }

        private void CreateData()
        {
            ListSubject = new ObservableCollection<MonHoc>(_repoMH.GetAll());

            ListKey = new ObservableCollection<string>() { "Mã Môn Học","Tên Môn Học"};

            RefeshData1 = new RelayCommand<object>
                (
                  (p) =>
                  {
                       return true;
                  },
                  (p)=>
                  {
                      MaMonHoc = TenMonHoc = SoTinChi = null;
                  }
                );
            ThemMonHoc = new RelayCommand<object>
                (
                  (p) =>
                  {
                      
                      return true;
                  },
                  (p)=>
                  {
                      var data = new MonHoc() { MaMonHoc = MaMonHoc, SoTinChi = Convert.ToInt32(SoTinChi), TenMonHoc = TenMonHoc };
                      var result = _repoMH.Insert(data);
                      if (result != null)
                          MessageBox.Show("OK");
                      else
                          MessageBox.Show("Fail");

                  }
                );


        }
    }
}
