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
    /// Interaction logic for CartItem.xaml
    /// </summary>
    public partial class CartItem : UserControl
    {
        public int cart_item_counter;

        public void RemoveItemCart(object sender, RoutedEventArgs e)
        {
            //var cartChildren = Switcher.GetCart().CartItemList.Children;

            foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
            {
                if (child.checkout_item_counter == this.cart_item_counter)
                {
                    Switcher.GetCheckout().CheckoutItemList.Children.Remove(child);
                    Switcher.GetCart().CartItemList.Children.Remove(this);
                    break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                }
            }

        }

        //Increase Quantity
        private void IncreaseQuantityCart(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.ItemQuantity.Text);
                this.ItemQuantity.Text = (current + 1).ToString();

                foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
                {
                    if (child.checkout_item_counter == this.cart_item_counter)
                    {
                        child.checkout_item_quantity = (current + 1).ToString();
                        child.CheckoutItemQuantity.Text = (current + 1).ToString();
                        break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        private void DecreaseQuantityCart(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.ItemQuantity.Text);
                if(current != 1)
                {
                    this.ItemQuantity.Text = (current - 1).ToString();

                    foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
                    {
                        if (child.checkout_item_counter == this.cart_item_counter)
                        {
                            child.checkout_item_quantity = (current - 1).ToString();
                            child.CheckoutItemQuantity.Text = (current - 1).ToString();
                            break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        public CartItem()
        {
            InitializeComponent();
        }
    }
}
