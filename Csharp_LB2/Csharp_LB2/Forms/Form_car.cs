using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_LB2;
using Csharp_LB2.Shop;

namespace Csharp_LB2.Forms
{
    public partial class Form_car : Form
    {
        private Shop.Shop _shop;

        public Form_car()
        {
            InitializeComponent();
        }

        public Form_car(Shop.Shop current_shop)
        {
            _shop = current_shop;
            InitializeComponent();
        }

        private void Add_car_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = c_brand_textbox.Text;
                string title = c_title_textbox.Text;
                string transmission = c_transmission_combobox.Text;
                string fuel = c_fuel_combobox.Text;
                double engine_capacity = Convert.ToDouble(c_capacity_textbox.Text);
                double fuel_consumption = Convert.ToDouble(c_consumption_textbox.Text);
                double cost_shop = Convert.ToDouble(c_costshop_textbox.Text);
                double cost_customer = Convert.ToDouble(c_costcustomer_textbox.Text);

                Car new_car = new Car(brand, title, transmission, fuel, engine_capacity, fuel_consumption, cost_shop, cost_customer);
                _shop.Add_Car(new_car); 
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
}
