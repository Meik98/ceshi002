using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{

  

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


        Page1 p1;
        Page2 p2;


        public MainWindow()
        {
            InitializeComponent();
            //将wpf设置为默认屏幕高度、宽度
            this.WindowState = System.Windows.WindowState.Maximized;//默认最大化
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;//将宽度设置为屏幕的宽度
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;//将高度设置为屏幕的高度


            p1 = new Page1();
            p2 = new Page2();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Content = p1;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Content = p2;
        }
    }
}
