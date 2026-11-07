using studyPrism2.ViewModels;
using studyPrism2.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace studyPrism2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
          containerRegistry.RegisterDialog<UCpage,UCpageViewModel>();
          containerRegistry.RegisterDialog<UCPage2,UCPage2ViewModel>();
        }
    }

}
