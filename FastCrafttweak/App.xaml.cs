using FastCrafttweakLib.Craft;
using FastCrafttweakLib.Item;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FastCrafttweak
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ItemInit.Init();
            CraftInit.Init();
        }
    }
}
