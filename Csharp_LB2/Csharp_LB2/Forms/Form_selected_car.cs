using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_LB2.Shop;

namespace Csharp_LB2.Forms
{
    public partial class Form_selected_car : Form
    {
        public Form_selected_car()
        {
            InitializeComponent();
        }

        public Form_selected_car(Car current_shop)
        {
            InitializeComponent();

            c_brand_textbox.Text = current_shop.Brand;
            c_title_textbox.Text = current_shop.Title;
            c_control_textbox.Text = current_shop.Control;
            c_fuel_textbox.Text = current_shop.Fuel;
            c_capacity_textbox.Text = Convert.ToString(current_shop.Engine_Capacity);
            c_consumption_textbox.Text = Convert.ToString(current_shop.Fuel_Consumption);
            c_costshop_textbox.Text = Convert.ToString(current_shop.Cost_For_Shop);
            c_costcustomer_textbox.Text = Convert.ToString(current_shop.Cost_For_Customer);
        }

        private void Form_selected_car_Load(object sender, EventArgs e)
        {

        }
    }
}
