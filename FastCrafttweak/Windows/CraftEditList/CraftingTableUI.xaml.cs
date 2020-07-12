using FastCrafttweak.Controls;
using FastCrafttweakLib.Craft.CraftList;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastCrafttweak.Windows.CraftEditList
{
    /// <summary>
    /// CraftingTableUI.xaml 的交互逻辑
    /// </summary>
    public partial class CraftingTableUI : UserControl, IPanle
    {
        public CraftingTable crafting { get; set; } = new CraftingTable();
        private int Last = 0;
        public CraftingTableUI()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            switch (crafting.CraftType)
            {
                case CraftType.Shaped:
                    S1.IsChecked = true;
                    break;
                case CraftType.Shapeless:
                    S2.IsChecked = true;
                    break;
            }
            if (crafting.Inputs.Length != 9)
            {
                MessageBox.Show("物品合成队列出错，已清空合成表队列");
                crafting.Inputs = new ItemObj[9];
            }
        }

        public void Set(CraftingTable crafting)
        {
            this.crafting = crafting;
            Update();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            crafting.CraftType = CraftType.Shaped;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            crafting.CraftType = CraftType.Shapeless;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            CButton button = (CButton)sender;
            if (Last == button.ULocal)
            {
                var data = button.Item;
                data.Count++;
                button.ChangeItem(data);
            }
            else
            {
                switch (Last)
                {
                    case 1:
                        I1.isClick = false;
                        break;
                    case 2:
                        I2.isClick = false;
                        break;
                    case 3:
                        I3.isClick = false;
                        break;
                    case 4:
                        I4.isClick = false;
                        break;
                    case 5:
                        I5.isClick = false;
                        break;
                    case 6:
                        I6.isClick = false;
                        break;
                    case 7:
                        I7.isClick = false;
                        break;
                    case 8:
                        I8.isClick = false;
                        break;
                    case 9:
                        I9.isClick = false;
                        break;
                    case 10:
                        O.isClick = false;
                        break;
                }
                switch (button.ULocal)
                {
                    case 1:
                        I1.isClick = true;
                        break;
                    case 2:
                        I2.isClick = true;
                        break;
                    case 3:
                        I3.isClick = true;
                        break;
                    case 4:
                        I4.isClick = true;
                        break;
                    case 5:
                        I5.isClick = true;
                        break;
                    case 6:
                        I6.isClick = true;
                        break;
                    case 7:
                        I7.isClick = true;
                        break;
                    case 8:
                        I8.isClick = true;
                        break;
                    case 9:
                        I9.isClick = true;
                        break;
                    case 10:
                        O.isClick = true;
                        break;
                }
                Last = button.ULocal;
            }
        }
        public void Call(ItemObj item)
        {
            switch (Last)
            {
                case 1:
                    I1.ChangeItem(item);
                    break;
                case 2:
                    I2.ChangeItem(item);
                    break;
                case 3:
                    I3.ChangeItem(item);
                    break;
                case 4:
                    I4.ChangeItem(item);
                    break;
                case 5:
                    I5.ChangeItem(item);
                    break;
                case 6:
                    I6.ChangeItem(item);
                    break;
                case 7:
                    I7.ChangeItem(item);
                    break;
                case 8:
                    I8.ChangeItem(item);
                    break;
                case 9:
                    I9.ChangeItem(item);
                    break;
                case 10:
                    O.ChangeItem(item);
                    break;
            }
        }

        private void MouseRightButtonDown_(object sender, MouseButtonEventArgs e)
        {
            CButton button = (CButton)sender;
            if (button.Item != null)
            {
                button.ChangeItem(null);
            }
        }

        private void UserControl_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            I1.isClick =
            I2.isClick =
            I3.isClick =
            I4.isClick =
            I5.isClick =
            I6.isClick =
            I7.isClick =
            I8.isClick =
            I9.isClick =
            O.isClick = false;
            Last = 0;
        }
    }
}
