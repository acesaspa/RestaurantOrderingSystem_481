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
        public bool item_peanut;
        public bool item_gluten;
        public bool item_vegetarian;
        public bool item_vegan;
        public bool item_halal;
        public bool item_koshur;



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
                this.ItemName.Content = this.item_name;
            }
        }


        // Item Description
        public string Item_description
        {
            get { return item_description; }
            
            set
            {
                item_description = value;
                this.ItemDescription.Content = this.item_description;
            }
        
        }

        //Item Price
        public float Item_price
        {
            get { return item_price; }

            set
            {
                item_price = value;
                this.ItemPrice.Content = this.item_price;
            }

        }


        // Item Characteristics:
        public bool Item_spicy
        {

            get { return item_spicy; }

            set { item_spicy = false;}

        }

        public bool Item_peanut
        {

            get { return item_peanut; }

            set{ item_peanut = false; }

        }

        public bool Item_gluten
        {

            get { return item_gluten; }

            set { item_gluten = false; }

        }

        public bool Item_vegetarian
        {

            get { return item_vegetarian; }

            set { item_vegetarian = false; }

        }

        public bool Item_vegan
        {

            get { return item_vegan; }

            set { item_vegan = false; }

        }

        public bool Item_halal
        {

            get { return item_halal; }

            set { item_halal = false; }

        }

        public bool Item_koshur
        {

            get { return item_koshur; }

            set { item_koshur = false; }

        }


        public MenuItem(string name, string desc, float price)
        {
            item_name = name;
            item_description = desc;
            item_price = price;
            
            InitializeComponent();
        }
    }
}
