using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace CarrotMeasure
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            SayHelloCommand = new RelayCommand<string>((arg) => SayHello(arg));
        }

        public RelayCommand<string> SayHelloCommand { get; set; }

        public void SayHello(string arg)
        {
            MessageBox.Show("Hello," + arg);
        }
    }
}
