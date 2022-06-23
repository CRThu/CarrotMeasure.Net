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
            container.Register<AppPage1ViewModel>();
            container.Register<AppPage2ViewModel>();
            container.Register<DevicesPageViewModel>();
            container.Register<LoggerPageViewModel>();
            container.Register<MainWindowViewModel>();
        }

        public AppPage1ViewModel AppPage1 => container.Resolve<AppPage1ViewModel>();
        public AppPage2ViewModel AppPage2 => container.Resolve<AppPage2ViewModel>();
        public DevicesPageViewModel DevicesPage => container.Resolve<DevicesPageViewModel>();
        public LoggerPageViewModel LoggerPage => container.Resolve<LoggerPageViewModel>();
        public MainWindowViewModel MainWindow => container.Resolve<MainWindowViewModel>();
    }
}
