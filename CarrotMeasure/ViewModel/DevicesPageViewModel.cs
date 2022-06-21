using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CarrotMeasure.ViewModel
{
    public class DevicesPageViewModel : ObservableObject
    {
        private int value=123456;
        public int Value
        {
            get { return value; }
            set { SetProperty(ref value, value); }
        }
    }
}
