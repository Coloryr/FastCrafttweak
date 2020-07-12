using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastCrafttweak.Windows
{
    /// <summary>
    /// WindowsOpen.xaml 的交互逻辑
    /// </summary>
    public partial class WindowsOpen : Window
    {
        public WindowsOpen()
        {
            InitializeComponent();
            App.WindowsOpen_ = this;
            Check();
        }

        public void Check()
        {
            L1.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Blue"));
            L2.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Blue"));
            L3.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Blue"));
            if (App.CraftEdit_ != null)
            {
                L3.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Green"));
            }
            if (App.ItemSelect_ != null)
            { 
                L1.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Green"));
            }
            if (App.ScriptSelect_ != null)
            {
                L2.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Green"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (App.ItemSelect_ == null)
            {
                App.ItemSelect_ = new ItemSelect();
                App.ItemSelect_.Show();
            }
            else
            {
                App.ItemSelect_.Activate();
            }
            Check();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (App.ScriptSelect_ == null)
            {
                App.ScriptSelect_ = new ScriptSelect();
                App.ScriptSelect_.Show();
            }
            else
            {
                App.ScriptSelect_.Activate();
            }
            Check();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (App.CraftEdit_ == null)
            {
                App.CraftEdit_ = new CraftEdit();
                App.CraftEdit_.Show();
            }
            else
            {
                App.CraftEdit_.Activate();
            }
            Check();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.CraftEdit_?.Close();
            App.ItemSelect_?.Close();
            App.ScriptSelect_?.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (App.MainWindow_ == null)
            {
                App.MainWindow_ = new MainWindow();
                App.MainWindow_.Show();
            }
        }
    }
}
