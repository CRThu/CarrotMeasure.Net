using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;

namespace CarrotMeasure.Net.ViewModel
{
    public class ViewModelLocator
    {
        private readonly Container container;

        public ViewModelLocator()
        {
            container = new();

            // Register
            container.Register<App1ViewModel>();
            container.Register<App2ViewModel>();
            container.Register<DevicesPageViewModel>();
            container.Register<LoggerPageViewModel>();
            container.Register<MainWindowViewModel>();
        }

        public App1ViewModel AppPage1 => container.Resolve<App1ViewModel>();
        public App2ViewModel AppPage2 => container.Resolve<App2ViewModel>();
        public DevicesPageViewModel DevicesPage => container.Resolve<DevicesPageViewModel>();
        public LoggerPageViewModel LoggerPage => container.Resolve<LoggerPageViewModel>();
        public MainWindowViewModel MainWindow => container.Resolve<MainWindowViewModel>();
    }
}
