using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure.ViewModel
{
    public class AppPage2ViewModel : ObservableObject
    {
        private string text = $"Get {App.Locator.AppPage1.Text} From AppPage1";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref value, value); }
        }
    }
}
