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
    public partial class Form_selected_worker : Form
    {
        public Form_selected_worker()
        {
            InitializeComponent();


        }

        public Form_selected_worker(Worker current_worker)
        {
            InitializeComponent();

            w_name_textbox.Text = current_worker.Name;
            w_surname_textbox.Text = current_worker.Surname;
            w_education_textbox.Text = current_worker.Education;
            w_salary_textbox.Text = Convert.ToString(current_worker.Salary);
            w_position_textbox.Text = current_worker.Position;
        }

        private void Form_selected_worker_Load(object sender, EventArgs e)
        {

        }
    }
}
