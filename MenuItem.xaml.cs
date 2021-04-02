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

            set { item_spicy = false;}

        }

        public bool Item_peanutfree
        {

            get { return item_peanutfree; }

            set{ item_peanutfree = false; }

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

        public MenuItem(string name, string desc, float price)
        {
            item_name = name;
            item_description = desc;
            item_price = price;
            InitializeComponent();

            MenuItemUC();
        }

        //Set all the Data for User Control
        public void MenuItemUC()
        {
            this.ItemName.Text = item_name;
            this.ItemDescription.Text = item_description;
            this.ItemPrice.Text = item_price.ToString();
        }

        public MenuItem()
        {
            InitializeComponent();
        }
    }
}
