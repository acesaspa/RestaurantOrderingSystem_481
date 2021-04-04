using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for AddingItem.xaml
    /// </summary>
    public partial class ItemAddition : UserControl
    {
        //Increase Quantity
        private void IncreaseQuantity(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(DisplayItemQuantity.Text);
                DisplayItemQuantity.Text = (current + 1).ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            CartItem cartItem = new CartItem();
            cartItem.ItemDescription.Text = DisplayItemDescription.Text;
            cartItem.ItemName.Text = DisplayItemName.Text;
            cartItem.ItemPrice.Text = DisplayItemPrice.Text;
            cartItem.ItemQuantity.Text = DisplayItemQuantity.Text;

            Switcher.GetCart().CartItemList.Children.Add(cartItem);
        }


        public ItemAddition()
        {
            InitializeComponent();
        }
    }
}
