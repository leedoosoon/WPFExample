using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPFExample.Service;

namespace WPFExample.ViewModel
{
    public class Sub1ViewModel : ViewModelBase
    {


        private IAgin _motorService = null;
        private CameraService _cameraService = null;
        

        public Sub1ViewModel(IAgin _moto)
        {
            _motorService = _moto;

        }


        private string _TestString = "";
        public string TestString
        {
            get => _TestString;
            set => Set<string>(nameof(TestString), ref _TestString, value);
        }

        private ICommand _HitCommand = null;
        public ICommand HitCommand
        {
            get
            {
                if(_HitCommand == null)
                {
                    _HitCommand = new RelayCommand(() =>
                    {
                        this.TestString = "adfadfafa";
                    });
                }

                return _HitCommand;
            }
        }
    }
}
