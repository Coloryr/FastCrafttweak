﻿using FastCrafttweak.Controls;
using FastCrafttweak.Windows.CraftEditList;
using FastCrafttweakLib.Item;
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
            App.ItemSelect_ = this;
            AddItem();
        }

        public void AddItem()
        {
            foreach (var item in Minecraft.MinecraftList)
            {
                var Button = new UButton()
                {
                    Texture = item.Value.Texture,
                    Content = item.Value.Name,
                    KeyName = item.Key
                };
                Button.Click += UButton_Click;
                I1.Children.Add(Button);
            }
        }

        private void UButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (UButton)sender;
            switch(button.ListName)
            {
                case ListName.Minecraft:
                    App.CraftEdit_?.Call(Minecraft.MinecraftList[button.KeyName]);
                    break;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.ItemSelect_ = null;
            App.WindowsOpen_?.Check();
        }
    }
}
