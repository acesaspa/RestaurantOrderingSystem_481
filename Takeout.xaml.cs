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
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Threading;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for Takeout.xaml
    /// </summary>
    public partial class Takeout : UserControl
    {
        public Takeout()
        {
            InitializeComponent();
        }

        public void Increase(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(DisplayQuantity.Text);
                current += 1;
                if (current > 1)
                {
                    DecreaseButton.Opacity = 100;
                }
                DisplayQuantity.Text = (current).ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        public void Decrease(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(DisplayQuantity.Text);

                if (current > 1)
                {
                    current -= 1;
                }
                else
                {
                    current = 1;
                }

                if (current == 1) 
                {
                    DecreaseButton.Opacity = 0;
                }

                DisplayQuantity.Text = (current).ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        async private void SuccessNotification(object sender, RoutedEventArgs e)
        {

            Window window = new Window
            {
                Title = "Success",
                Content = Switcher.GetSuccessNotification(),
                Height = 200,
                Width = 200
            };
            window.Show();

            await Task.Run(() =>
            {

                Thread.Sleep(2000);

            });

            window.Close();
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }

        private void CloseTakeout(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }
    }
}
