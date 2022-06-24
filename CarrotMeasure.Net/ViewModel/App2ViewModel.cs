using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure.Net.ViewModel
{
    public class App2ViewModel : GeneralAppViewModel
    {
        private string text = $"Get {App.Locator.AppPage1.Text} From AppPage1";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref value, value); }
        }
    }
}
