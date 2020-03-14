using GalaSoft.MvvmLight;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using WPFExample.Service;
using CommonServiceLocator;

namespace WPFExample.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {


        public MainViewModel()
        {


           
        }

        private ViewModelBase _SubContent = null;
        public ViewModelBase SubContent
        {
            get => _SubContent;
            set =>Set<ViewModelBase>(nameof(SubContent), ref _SubContent, value);
            
        }



        private ICommand _ViewModel1Command = null;
        public ICommand ViewModel1Command
        {

            get
            {
                if (_ViewModel1Command == null)
                {
                    _ViewModel1Command = new RelayCommand(() =>
                    {
                        this.SubContent = ServiceLocator.Current.GetInstance<Sub1ViewModel>();
                    });
                }

                return _ViewModel1Command;
            }

        }


        private ICommand _ViewModel2Command = null;
        public ICommand ViewModel2Command
        {

            get
            {
                if (_ViewModel2Command == null)
                {
                    _ViewModel2Command = new RelayCommand(() =>
                    {
                        this.SubContent = ServiceLocator.Current.GetInstance<Sub2ViewModel>();
                    });
                }

                return _ViewModel2Command;
            }

        }
    }
}