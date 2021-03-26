﻿using System;
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

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Adding Our Items
            for(int i = 0; i < 15; i++)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.ItemName.Content = "Item: " + i.ToString();
                menuItem.ItemDescription.Content = "ItemDescription: " + i.ToString();
                Switcher.GetMenu().MenuItemList.Children.Add(menuItem);
            }


            Switcher.pageSwitcher = this;
            Switcher.Switch(Switcher.GetLanding());

        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

    }
}
