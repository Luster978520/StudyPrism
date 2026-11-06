using PrismBaseObj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismBaseObj
{
    class MainWindowViewModel : BindableBase
    {


        public DelegateCommand OpenCmm { get; set; }


        private string _title = "好好学习";

        public string Title
        {
            get { return _title; }
            set
            {

                SetProperty(ref _title, value);

            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                SetProperty<string>(ref _name, value);
            }
        }

        private UserInfo _userinfo;

        public UserInfo userInfo
        {
            get { return _userinfo; }
            set
            {
                SetProperty<UserInfo>(ref _userinfo, value);
            }
        }


        public DelegateCommand EditCommand { get; set; }         
        public DelegateCommand<string> showMessageCommand { get; set; }  //执行这个命令的时候传入的参数类型<string>


        public DelegateCommand<UserInfo> UserInfoCommand { get; set; }  //执行这个命令的时候传入的参数类型<UserInfo>

        public MainWindowViewModel()
        {
            EditCommand = new DelegateCommand(EditName);

            showMessageCommand = new DelegateCommand<string>(showMessage);
            userInfo = new UserInfo() { IdCard="1231231",UserName="王五"};

            UserInfoCommand = new DelegateCommand<UserInfo>(showUserInfo);

            OpenCmm=new DelegateCommand(() => { 
                    MessageBox.Show("打开窗体");
            });
        }

        private void showUserInfo(UserInfo info)
        {
            MessageBox.Show($"用户身份证是{info.IdCard},用户的姓名是{info.UserName}");
            userInfo.UserName = info.UserName;
            userInfo.IdCard = info.IdCard;
            MessageBox.Show($"修改后用户身份证是{info.IdCard},用户的姓名是{info.UserName}");

        }

        private void showMessage(string Name1)
        {
                 Name= Name1;
        }

        private void EditName()
        {
            Title = "Fitst Name";
        }




      

    }




}
