using FastCrafttweak.Windows.CraftEditList;
using FastCrafttweakLib.Craft;
using FastCrafttweakLib.Item;
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
using static FastCrafttweakLib.Craft.CraftInit;

namespace FastCrafttweak.Windows
{
    /// <summary>
    /// CraftEdit.xaml 的交互逻辑
    /// </summary>
    public partial class CraftEdit : Window
    {
        private IPanle nowPanle;
        private CraftListType CraftType = CraftListType.CraftingTable;
        public CraftEdit()
        {
            InitializeComponent();
            App.CraftEdit_ = this;
            SetType(CraftListType.CraftingTable);
        }

        public void SetType(CraftListType CraftType)
        {
            this.CraftType = CraftType;
            UI.Children.Clear();
            switch (this.CraftType) 
            {
                case CraftListType.CraftingTable:
                    dynamic data = new CraftingTableUI();
                    UI.Children.Add(data);
                    nowPanle = data;
                    break;
                default:
                    break;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.CraftEdit_ = null;
            App.WindowsOpen_?.Check();
        }

        public void Call(ItemObj item)
        {
            nowPanle.Call(item);
        }
    }
}
