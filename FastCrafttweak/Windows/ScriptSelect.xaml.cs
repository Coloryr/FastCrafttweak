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
    /// ScriptSelect.xaml 的交互逻辑
    /// </summary>
    public partial class ScriptSelect : Window
    {
        public ScriptSelect()
        {
            InitializeComponent();
            App.ScriptSelect_ = this;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.ScriptSelect_ = null;
            App.WindowsOpen_?.Check();
        }
    }
}
