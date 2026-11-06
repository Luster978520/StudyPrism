using PrismBaseObj.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PrismBaseObj
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private BtnStyleShowFrm btnStyleShowFrm;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnStyleShowFrm==null)
            {
                btnStyleShowFrm = new BtnStyleShowFrm();
                btnStyleShowFrm.Closed += (e, args) =>
                {
                    btnStyleShowFrm = null;
                };
                btnStyleShowFrm.Show();
            }
            else
            {
                if (btnStyleShowFrm.WindowState==WindowState.Minimized)
                {
                    btnStyleShowFrm.WindowState = WindowState.Normal;
                    btnStyleShowFrm.Activate();
                }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}