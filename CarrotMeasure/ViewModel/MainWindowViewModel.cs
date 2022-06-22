using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CarrotMeasure.Utility;
using CarrotMeasure.ViewModel.ComponentModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace CarrotMeasure.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            SayHelloCommand = new RelayCommand<string>((arg) => SayHello(arg));
            ThemeChangeCommand = new RelayCommand<Theme>((arg) => ThemeChange(arg));

            Themes = new(EnumEx.GetAllItems<Theme>().Select(t => new ThemeMenuItem() { Name = t }));
            SelectedTheme = new AvalonDock.Themes.Vs2013LightTheme();
            Themes.Where(t => t.Name == Theme.VS2013LightTheme).First().IsChecked = true;
        }

        private AvalonDock.Themes.Theme selectedTheme;
        /// <summary>
        /// 当前主题
        /// </summary>
        public AvalonDock.Themes.Theme SelectedTheme
        {
            get { return selectedTheme; }
            set { SetProperty(ref selectedTheme, value); }
        }

        private ObservableCollection<ThemeMenuItem> themes;
        /// <summary>
        /// 主题列表
        /// </summary>
        public ObservableCollection<ThemeMenuItem> Themes
        {
            get { return themes; }
            set { SetProperty(ref themes, value); }
        }


        public void SayHello(string arg)
        {
            MessageBox.Show("Hello," + arg);
        }

        /// <summary>
        /// 切换界面主题
        /// </summary>
        /// <param name="arg"><see cref="Theme"/>枚举的字符串类型</param>
        public void ThemeChange(Theme arg)
        {
            for (int i = 0; i < Themes.Count; i++)
            {
                Themes[i].IsChecked = false;
            }
            Themes.Where(t=>t.Name==arg).First().IsChecked = true;

            SelectedTheme = arg switch
            {
                Theme.VS2013LightTheme => new AvalonDock.Themes.Vs2013LightTheme(),
                Theme.VS2013BlueTheme => new AvalonDock.Themes.Vs2013BlueTheme(),
                Theme.VS2013DarkTheme => new AvalonDock.Themes.Vs2013DarkTheme(),
                _ => throw new NotImplementedException(),
            };
            //WeakReferenceMessenger.Default.Send(arg, "ChangeTheme");
        }

        #region RelayCommand
        /// <summary>
        /// <see cref="RelayCommand{T}"/> of <see cref="SayHello(string)"/>
        /// </summary>
        public RelayCommand<string> SayHelloCommand { get; set; }
        /// <summary>
        /// <see cref="RelayCommand{T}"/> of <see cref="ThemeChange(Theme)"/>
        /// </summary>
        public RelayCommand<Theme> ThemeChangeCommand { get; set; }
        #endregion
    }
}
