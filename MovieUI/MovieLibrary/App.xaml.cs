using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MovieLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        AppDomain currentDomain = AppDomain.CurrentDomain;
       
        protected override void OnStartup(StartupEventArgs e)
        {
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnException);
            base.OnStartup(e);
        }
        static void OnException(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show("Internal Server Error","Handler",MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
