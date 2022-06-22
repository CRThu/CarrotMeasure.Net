using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotMeasure.ViewModel.ComponentModel
{
    public class ThemeMenuItem : ObservableObject
    {
        private Theme name;
        /// <summary>
        /// 主题名称
        /// </summary>
        public Theme Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private bool isChecked;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChecked
        {
            get { return isChecked; }
            set { SetProperty(ref isChecked, value); }
        }
    }
}
