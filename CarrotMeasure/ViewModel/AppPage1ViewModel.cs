using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure.ViewModel
{
    public class AppPage1ViewModel : ObservableObject
    {
        private string text = "AppPage1Text";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref value, value); }
        }
    }
}
