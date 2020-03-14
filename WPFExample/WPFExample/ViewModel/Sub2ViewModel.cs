using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WPFExample.Service;

namespace WPFExample.ViewModel
{
    public class Sub2ViewModel : ViewModelBase
    {

        private IAgin _motorService = null;
        private CameraService _cameraService = null;


        public Sub2ViewModel(IAgin _motor)
        {
            _motorService = _motor;

        }
    }
}
