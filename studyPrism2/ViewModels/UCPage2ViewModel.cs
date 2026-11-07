using studyPrism2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace studyPrism2.ViewModels
{
    class UCPage2ViewModel : BindableBase, IDialogAware
    {

        public string Title => "用户界面2";
        public DialogCloseListener RequestClose {
            get;
        }

        public DelegateCommand SubCmd { get; set; }

        private IEventAggregator _eventAggregator;

        public DelegateCommand UnSubCmd { get; set; }

        public UCPage2ViewModel(IEventAggregator eventArggregator)
        {

            SubCmd = new DelegateCommand(subMethod);
            UnSubCmd = new DelegateCommand(UnsubMethod);
            _eventAggregator = eventArggregator;
        }

        private void UnsubMethod()
        {
            _eventAggregator.GetEvent<MsgEvent>().Unsubscribe(SendMessage);
        }

        private void subMethod()
        {
            _eventAggregator.GetEvent<MsgEvent>().Subscribe(SendMessage);
        }

        private void SendMessage() {
            MessageBox.Show("用户窗体2");
        }
        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
         
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
