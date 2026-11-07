using System.Configuration;
using System.Data;
using System.Windows;
using PrismBaseObj.Views;
using PrismBaseObj.ViewModels;
using PrismBaseObj.Model;

namespace PrismBaseObj
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        /// <summary>
        /// 启动窗体
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override Window CreateShell()
        {
           return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<DialogUC, DialogUCViewModel>();
            containerRegistry.RegisterDialog<newPageshow>();
        }
    }

}
