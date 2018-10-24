using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace splashTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.Sleep(9000);
            if(App.Dic.ContainsKey("SplashWindow"))
            {
                load sw = App.Dic["SplashWindow"] as load;
                sw.Dispatcher.Invoke((Action)(() => sw.Close()));//在sw的线程上关闭SplashWindow
            }
        }
    }
}
