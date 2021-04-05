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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {

        /***************************
         
            Variable Declarations:
         
        ***************************/

        // Item Name
        public string item_name;

        // Item Description
        public string item_description;

        // Item Price
        public float item_price;

        // Item Image Location
        public string item_image;

        // Item Characteristics
        public bool item_spicy;
        public bool item_peanutfree;
        public bool item_vegetarian;
        public bool item_glutenfree;



        /***************************

             Getters & Setters:

        ***************************/

        // Item Name (ItemName)
        public string Item_name
        {
            get { return item_name; }
            set
            {
                item_name = value;
                this.ItemName.Text = this.item_name;
            }
        }


        // Item Description
        public string Item_description
        {
            get { return item_description; }

            set
            {
                item_description = value;
                this.ItemDescription.Text = this.item_description;
            }

        }
        //item6.ItemImage.Source = new BitmapImage(new Uri(@"/Resources/trash.png", UriKind.Relative));
        // Item Image
        public string Item_image
        {
            get { return item_image; }

            set
            {
                item_image = value;
                this.ItemImage.Source = new BitmapImage(new Uri(@"" + this.item_image, UriKind.Relative));

            }

        }

        //Item Price
        public float Item_price
        {
            get { return item_price; }

            set
            {
                item_price = value;
                this.ItemPrice.Text = this.item_price.ToString();
            }

        }


        // Item Characteristics:
        public bool Item_spicy
        {

            get { return item_spicy; }

        }

        public bool Item_peanutfree
        {

            get { return item_peanutfree; }

            set { item_peanutfree = false; }

        }

        public bool Item_glutenfree
        {

            get { return item_glutenfree; }

            set { item_glutenfree = false; }

        }



        public bool Item_vegetarian
        {

            get { return item_vegetarian; }

            set { item_vegetarian = false; }

        }

        //private void ReviewOrder(object sender, RoutedEventArgs e)
        //{
        //    Window window = new Window
        //    {
        //        Title = "Review Order",
        //        Content = Switcher.GetReviewOrder(),
        //        Height = 400,
        //        Width = 300
        //    };
        //    window.ShowDialog();
        //}

        //Item Select
        public void ItemSelect(object sender, RoutedEventArgs e)
        {
            ItemAddition showItem = new ItemAddition();
            showItem.DisplayItemName.Text = this.ItemName.Text;
            showItem.DisplayItemDescription.Text = this.ItemDescription.Text;
            showItem.DisplayItemPrice.Text = this.ItemPrice.Text;

            Window window = new Window
            {
                Title = "Item Select",
                Content = showItem,
                Height = 350,
                Width = 300
            };

            window.ShowDialog();
        }

        public MenuItem(string name, string desc, float price, string image, bool spicy, bool peanutFree, bool glutenFree, bool vegetarian)
        {
            item_name = name;
            item_description = desc;
            item_price = price;
            item_image = image;
            item_spicy = spicy;
            item_peanutfree = peanutFree;
            item_glutenfree = glutenFree;
            item_vegetarian = vegetarian;

            InitializeComponent();

            MenuItemUC();
        }

        //Set all the Data for User Control
        public void MenuItemUC()
        {
            this.ItemName.Text = item_name;
            this.ItemDescription.Text = item_description;
            this.ItemPrice.Text = "$" + item_price.ToString();
            this.ItemImage.Source = new BitmapImage(new Uri(@"" + item_image, UriKind.Relative));

            // If Item is spicy, add the spicy icon
            // i.e. set the content of the SpicyImage.
            if (this.Item_spicy)
            {

                this.SpicyImage.Source = new BitmapImage(new Uri(@"Resources/PepperIcon.png", UriKind.Relative));

            }

            // If Item doesn't peanuts, add the spicy icon
            // i.e. set the content of the PeanutImage.
            if (this.Item_peanutfree)
            {
                this.PeanutImage.Source = new BitmapImage(new Uri(@"Resources/Peanut.png", UriKind.Relative));
            }

            // If Item doesn't contain gluten or has gluten-free options,
            // i.e. set the content of the Gluten.
            if (this.Item_glutenfree)
            {
                this.GlutenImage.Source = new BitmapImage(new Uri(@"Resources/gluten.png", UriKind.Relative));
            }

            // If Item doesn't contain gluten or has gluten-free options,
            // i.e. set the content of the Gluten.
            if (this.Item_vegetarian)
            {
                this.VegetarianImage.Source = new BitmapImage(new Uri(@"Resources/CarrotIcon.png", UriKind.Relative));
            }

        }

        public MenuItem()
        {
            InitializeComponent();
        }
    }
}
