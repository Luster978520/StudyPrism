using studyPrism2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyPrism2
{
    class MainWindowViewModel:BindableBase
    {


        public DelegateCommand OpenPage1Cmd { get; }
        public DelegateCommand OpenPage2Cmd { get; }
        public DelegateCommand PublicCmd { get; }
        public DelegateCommand PublicParaCmd { get; }
        private IDialogService dialogService;
        private IEventAggregator eventAggregator1;

        public MainWindowViewModel(IDialogService dialogService,IEventAggregator eventAggregator)
        {
            OpenPage1Cmd = new DelegateCommand(OpenPage1);
            OpenPage2Cmd = new DelegateCommand(OpenPage2);
            PublicCmd = new DelegateCommand(PublicMethod);
            PublicParaCmd = new DelegateCommand(PublicMethod2);
            this.dialogService = dialogService;
            eventAggregator1 = eventAggregator;
        }

        private void PublicMethod2()
        {
            eventAggregator1.GetEvent<MsgEventPara>().Publish("发布者发布带参数的");
        }

        private void PublicMethod()
        {
            eventAggregator1.GetEvent<MsgEvent>().Publish();  //不带参数的发布
        }

        private void OpenPage2()
        {
            dialogService.Show("UCpage");
        }

        private void OpenPage1()
        {
            dialogService.Show("UCPage2");

        }
    }
}
