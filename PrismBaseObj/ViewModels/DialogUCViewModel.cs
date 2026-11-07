using PrismBaseObj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismBaseObj.ViewModels
{
    public class DialogUCViewModel : BindableBase,IDialogAware
    {

        public DelegateCommand closedCmmd { get; set; }  //关闭窗体的命令



        private IDialogParameters _parameters; //接受主窗体传过来的参数
        public DelegateCommand receiveCmmd { get; set; }


       

        public DialogUCViewModel()
        {
            receiveCmmd = new DelegateCommand(ReceiveCmmdExecute);

            closedCmmd=new DelegateCommand(ClosedCmmdExecute);
        }

        private void ClosedCmmdExecute()
        {
            var result = new DialogResult();
            result.Parameters.Add("resMsg", "成功了");
            RequestClose.Invoke(result);
        }

        private void ReceiveCmmdExecute()
        {
            string uName= _parameters.GetValue<string>("UserName");
        }

        public string Title => "用户信息";
        private string  _showMessage="问题";

        public string  Message
        {
            get { return _showMessage; }
            set { SetProperty(ref _showMessage, value); }
        }


        private UserInfo _userinfo;

        public UserInfo UserInfo
        {
            get { return _userinfo; }
            set {
                SetProperty(ref _userinfo,value);
            }
        }

        public DialogCloseListener RequestClose { get; }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            // 对话框关闭后的清理工作放在这里，不再请求关闭。
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            _parameters = parameters;
           
           Message= _parameters.GetValue<string>("UserName");
            UserInfo = _parameters.GetValue<UserInfo>("Userinfo");
            string name = UserInfo.IdCard;
            string name2 = UserInfo.UserName;
            // Use the paramValue as needed
        }
    }
}
