﻿using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {
        public string item_name;
        public string Item_name
        {
            get { return item_name; }
            set
            {
                //item_name = value;
                //this.item_nameText.Content = this.item_name;
            }
        }
        public MenuItem()
        {
            InitializeComponent();
        }
    }
}
