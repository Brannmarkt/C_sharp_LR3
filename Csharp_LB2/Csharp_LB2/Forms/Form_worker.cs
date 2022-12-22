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
    public partial class Form_worker : Form
    {
        private Shop.Shop _shop;

        public Form_worker()
        {
            InitializeComponent();
        }
        public Form_worker(Shop.Shop current_shop)
        {
            _shop = current_shop;
            InitializeComponent();
        }

        private void Add_worker_Click(object sender, EventArgs e)
        {
            try
            {
                string name = w_name_textbox.Text;
                string surname = w_surname_textbox.Text;
                string education = w_education_textbox.Text;
                string position = w_position_combobox.Text;
                double salary = Convert.ToDouble(w_salary_textbox.Text);

                Worker new_worker = new Worker(name, surname, education, position, salary);
                _shop.Add_Worker(new_worker);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
}
