using studyPrism2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace studyPrism2.ViewModels
{
    class UCpageViewModel : BindableBase, IDialogAware
    {
        public string Title => "用户界面1";

        public DialogCloseListener RequestClose { get; }
        public DelegateCommand SubCmd { get; }


        public DelegateCommand SubParaCmd { get; }
        public DelegateCommand unSubParaCmd { get; }

        private IEventAggregator _eventAggregator;
        public UCpageViewModel(IEventAggregator eventAggregator) {
          
            SubCmd = new DelegateCommand(subMethod);
            SubParaCmd = new DelegateCommand(subMethodPara);
            unSubParaCmd = new DelegateCommand(unSubMethodPara);
            _eventAggregator = eventAggregator;
        }

        private void unSubMethodPara()
        {
            _eventAggregator.GetEvent<MsgEventPara>().Unsubscribe(methodPara);
        }

        private void subMethodPara()
        {
            _eventAggregator.GetEvent<MsgEventPara>().Subscribe(methodPara);
        }

        private void methodPara(string a) {
            MessageBox.Show("用户界面1收到了消息是：" + a);
        }

        private void subMethod()
        {
            _eventAggregator.GetEvent<MsgEvent>().Subscribe(
                () => {
                    MessageBox.Show("用户界面1收到消息");
                }
                );
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
