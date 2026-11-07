using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismBaseObj.ViewModels
{
    public class newPageshowViewModel : IDialogAware
    {


        public string Title => "用户信息";
        DialogCloseListener IDialogAware.RequestClose {
            get;
        }

        bool IDialogAware.CanCloseDialog()
        {
            return true;
        }

        void IDialogAware.OnDialogClosed()
        {
            MessageBox.Show("OnDialogClosed");
        }

        void IDialogAware.OnDialogOpened(IDialogParameters parameters)
        {
            MessageBox.Show("OnDialogOpened");
        }
    }
}
