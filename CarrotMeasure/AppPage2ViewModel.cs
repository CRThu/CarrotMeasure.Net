using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure
{
    public class AppPage2ViewModel : ObservableObject
    {
        private string text = "PAGE3";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref value, value); }
        }
    }
}
