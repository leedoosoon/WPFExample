using GalaSoft.MvvmLight;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using CommonServiceLocator;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Ioc;
using WPFExample.Model;

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
            ViewModelCollection.Add(new MainMenu()
            {
                Name = "Example1",
                ViewMode = SimpleIoc.Default.GetInstance<Example1ViewModel>()
            });

            ViewModelCollection.Add(new MainMenu()
            {
                Name = "Example2",
                ViewMode = SimpleIoc.Default.GetInstance<Example2ViewModel>()
            });

            ViewModelContent = SimpleIoc.Default.GetInstance<Example1ViewModel>();
        }

        private ViewModelBase _ViewModelContent = null;     //  Backing Field
        public ViewModelBase ViewModelContent
        {
            get => _ViewModelContent;
            set => Set<ViewModelBase>(nameof(ViewModelContent), ref _ViewModelContent, value);
        }

        private ObservableCollection<MainMenu> _ViewModelCollection = null;
        public ObservableCollection<MainMenu> ViewModelCollection
        {
            get
            {
                if (_ViewModelCollection == null)
                {
                    _ViewModelCollection = new ObservableCollection<MainMenu>();
                }

                return _ViewModelCollection;
            }
            //set => Set<ObservableCollection<ViewModelBase>>(nameof(ViewModelCollection), ref _ViewModelCollection, value);
        }


        private MainMenu _SelectedMenu = null;     //  Backing Field
        public MainMenu SelectedMenu
        {
            get => _SelectedMenu;
            set
            {
                if (null != value)
                {
                    ViewModelContent = value.ViewMode;
                }

                Set<MainMenu>(nameof(SelectedMenu), ref _SelectedMenu, value);
            }
        }
    }
}