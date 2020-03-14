/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WPFExample"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using WPFExample.Service;
//using WPFExample.Service;

namespace WPFExample.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        /// 
        bool IsDesignTime = true;
  

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if(IsDesignTime == false)
            {
                SimpleIoc.Default.Register<IAgin, AginMotor>();
            }
            else
            {
                SimpleIoc.Default.Register<IAgin, DummyAginMotor>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Sub1ViewModel>();
            SimpleIoc.Default.Register<Sub2ViewModel>();
        }

        public MainViewModel MainVIewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();

            }
        }

        public Sub1ViewModel Sub1ViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Sub1ViewModel>();
            }
        }



        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}