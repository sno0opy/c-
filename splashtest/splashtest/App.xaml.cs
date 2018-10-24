using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace splashTest
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread.Sleep(5000);
        }

        public static Dictionary<string, object> Dic = new Dictionary<string, object>();

        protected override void OnStartup(StartupEventArgs e)
        {
            //load s = new load();
            //s.Show();
            Thread t = new Thread(() =>
            {
                load sw = new load();
                Dic["SplashWindow"] = sw;//储存
                sw.ShowDialog();//不能用Show
            });
            t.SetApartmentState(ApartmentState.STA);//设置单线程
            t.Start();
            base.OnStartup(e);
            /*
            SplashScreen s = new SplashScreen(@"image\启动.gif");
            //显示初始屏幕 自动关闭设置false
            s.Show(true,true);
            //在3秒后关闭
            //s.Close(new TimeSpan(0, 0, 5));
            base.OnStartup(e);
            */
        }
    }
}
