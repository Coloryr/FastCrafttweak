using FastCrafttweak.Controls;
using FastCrafttweakLib.Item.ItemList;
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
    /// ItemSelect.xaml 的交互逻辑
    /// </summary>
    public partial class ItemSelect : Window
    {
        public ItemSelect()
        {
            InitializeComponent();
            AddItem();
        }

        public void AddItem()
        {
            foreach (var item in Minecraft.MinecraftList)
            {
                var Button = new UButton()
                {
                    Texture = item.Texture,
                    Content = item.Name
                };
                I1.Children.Add(Button);
            }
        }

        private void UButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (UButton)sender;
        }
    }
}
