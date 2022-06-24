using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure.Net.ViewModel
{
    public class App1ViewModel : GeneralAppViewModel
    {
        private string text = "AppPage1Text";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref value, value); }
        }
    }
}
