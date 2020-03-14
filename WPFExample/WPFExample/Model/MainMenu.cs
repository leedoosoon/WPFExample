using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample.Model
{
    public class MainMenu
    {
        public string Name
        {
            get;
            set;
        }

        public ViewModelBase ViewMode
        {
            get;
            set;
        }
    }
}
