using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismBaseObj.ViewModels
{
    public class BtnStyleShowFrmViewModel:BindableBase
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set {
                SetProperty(ref _id, value);
                showIntCmd.RaiseCanExecuteChanged();
            }
        }


       public DelegateCommand<int?> showIntCmd { get; set; }  //执行这个命令的时候传入的参数类型<int>







        private string name;
        public string Name {
            get { return name; }
            set { SetProperty(ref name, value); 
            Execmm.RaiseCanExecuteChanged();  //当Name属性改变时，通知命令CanExecute状态可能改变
        }
        }


        public DelegateCommand Execmm { get; set; }  //执行命令

        public BtnStyleShowFrmViewModel() {
            Execmm=new DelegateCommand(ExecmmMethod,CanExecte);


            showIntCmd=new DelegateCommand<int?>(showIntMethod,CanExecuted);
        }

        private void showIntMethod(int? obj)
        {
            MessageBox.Show("显示方法222");
        }

        private bool CanExecuted(int? arg)
        {
            if (arg > 0)
            {
                return true;
            }
            else
                return false;
        }

     

        private bool CanExecte()
        {

            
            return !string.IsNullOrEmpty(Name);
        }

        private void ExecmmMethod()
        {
            MessageBox.Show("显示方法");
        }


       
    }
}
