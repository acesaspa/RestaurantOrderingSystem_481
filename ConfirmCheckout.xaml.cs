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
    /// Interaction logic for ConfirmCheckout.xaml
    /// </summary>
    public partial class ConfirmCheckout : UserControl
    {
        public ConfirmCheckout()
        {
            InitializeComponent();
        }

        private void Close_Confirmation(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }

        private void Confirm_Order(object sender, RoutedEventArgs e)
        {

            if(Switcher.GetConfirmCheckout().VerifyNo.Text == "1234")
            {
                Run_Confirm_Order(sender, e);
            }
            else
            {
                MessageBox.Show("Wrong Verification Number Input!");
            }

        }

        private void Run_Confirm_Order(object sender, RoutedEventArgs e)
        {
            Confirm_Order2(sender, e);
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
            Switcher.Switch(Switcher.GetFinalize());
        }

        private void Confirm_Order2(object sender, RoutedEventArgs e)
        {
            float addReviewOrderSubtotal = 0.00f;

            //Clear Checkout UC Children
            Switcher.GetReviewOrder().ReviewItemList.Children.Clear();

            foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
            {
                ReviewOrderItem reviewOrderItem = new ReviewOrderItem();
                reviewOrderItem.ReviewOrderItemName.Text = child.CheckoutItemName.Text;
                reviewOrderItem.ReviewOrderItemPrice.Text = child.CheckoutItemPrice.Text;
                reviewOrderItem.ReviewOrderItemQuantity.Text = child.CheckoutItemQuantity.Text;
                reviewOrderItem.ReviewOrderSR.Text = child.CheckoutItemSR.Text;

                Switcher.GetReviewOrder().ReviewItemList.Children.Add(reviewOrderItem);


                //Adding Prices for Review Page
                string temp = reviewOrderItem.ReviewOrderItemPrice.Text.Substring(1);
                float itemPrice = float.Parse(temp);
                float totalItemPrice = itemPrice * (float.Parse(reviewOrderItem.ReviewOrderItemQuantity.Text));

                addReviewOrderSubtotal += totalItemPrice;
            }

            //Last Calculation for Prices
            float addReviewOrderGST = addReviewOrderSubtotal * MainWindow.GST;
            float addReviewOrderTotal = addReviewOrderSubtotal + addReviewOrderGST;

            //Set Calculation Prices on ReviewOrder
            Switcher.GetReviewOrder().ReviewOrderSubtotal.Text = "$" + addReviewOrderSubtotal.ToString("0.00");
            Switcher.GetReviewOrder().ReviewOrderGST.Text = "$" + addReviewOrderGST.ToString("0.00");
            Switcher.GetReviewOrder().ReviewOrderTotal.Text = "$" + addReviewOrderTotal.ToString("0.00");

            if (MainWindow.hasAlcohol == true)
            {
                this.Confirm_Alcohol.Text = "Alcohol";
            }

            //Clear Checkout and Cart
            Switcher.GetCheckout().CheckoutItemList.Children.Clear();
            Switcher.GetCart().CartItemList.Children.Clear();

            //Clear Pricing
            MainWindow.GlobalSubtotal = 0;

            //Prices
            Switcher.GetCart().CartMenuTotal.Text = "$0.00";
            Switcher.GetCheckout().Subtotal.Text = ("$0.00");
            Switcher.GetNewMenu().MenuTotal.Text = ("$0.00");
            Switcher.GetCheckout().GST.Text = "$0.00";
            Switcher.GetCheckout().Total.Text = "$0.00";



            
        }
    }
}
