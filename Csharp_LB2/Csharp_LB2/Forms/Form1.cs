using Csharp_LB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

using Csharp_LB2.Shop;

using Csharp_LB2.Forms;

namespace Csharp_LB2
{
    public partial class Form1 : Form
    {
        readonly private string _pathToShopsDataFile = @"E:\Projects\Csharp_LB2\Shops.json";
        readonly private string _pathToCarsDataFile = @"E:\Projects\Csharp_LB2\Cars.json";
        readonly private string _pathToWorkersDataFile = @"E:\Projects\Csharp_LB2\Workers.json";

        public Form1()
        {
            InitializeComponent();
            this.Load += LoadEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string title_ = title_textbox.Text;
                string address_ = address_textbox.Text;
                int departments_ = Convert.ToInt32(departments_textbox.Text);
                int workers_ = Convert.ToInt32(workers_textbox.Text);
                double income_ = Convert.ToInt32(income_textbox.Text);
                double outcome_ = Convert.ToInt32(outcome_textbox.Text);
                double salary_ = Convert.ToInt32(salary_textbox.Text);
                int goods_ = Convert.ToInt32(goods_textbox.Text);

                Shop.Shop created_shop = new Shop.Shop(title_, address_, departments_, workers_, income_, outcome_, salary_, goods_);
                AddElement(created_shop);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void AddElement(Shop.Shop newshop)
        {
            var Listview_item = new ListViewItem(newshop.Title);
            Listview_item.Tag = newshop;
            List_view.Items.Add(Listview_item);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = List_view.SelectedItems[0];
                List_view.Items[item.Index].Remove();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void ShowElementInList(object sender, EventArgs e)
        {
            if (List_view.SelectedItems.Count > 0)
            {
                var shop = (Shop.Shop)List_view.SelectedItems[0].Tag;

                if (shop != null)
                {
                    title_textbox.Text = shop.Title;
                    address_textbox.Text = shop.Adress;
                    if (shop.Cars == null)
                    {
                        departments_textbox.Text = "0";
                    }
                    else
                    {
                        departments_textbox.Text = shop.Cars.Count().ToString();
                    }

                    if (shop.Workers == null)
                    {
                        workers_textbox.Text = "0";
                    }
                    else
                    {
                        workers_textbox.Text = shop.Workers.Count().ToString();
                    }
                    income_textbox.Text = shop.Total_Income.ToString();
                    outcome_textbox.Text = shop.Total_Outcome.ToString();
                    salary_textbox.Text = shop.Total_Salary.ToString();
                    goods_textbox.Text = shop.Number_Of_Goods.ToString();
                }


                W_List_view.Clear();
                foreach (var worker in shop.Workers)
                {
                    ListViewItem item = new(worker.Name);
                    item.Tag = worker;
                    W_List_view.Items.Add(item);
                }

                C_List_view.Clear();
                foreach (var car in shop.Cars)
                {
                    ListViewItem item = new(car.Brand);
                    item.Tag = car;
                    C_List_view.Items.Add(item);
                }
            }
            else
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            title_textbox.Text = string.Empty;
            address_textbox.Text = string.Empty;
            departments_textbox.Text = string.Empty;
            workers_textbox.Text = string.Empty;
            income_textbox.Text = string.Empty;
            outcome_textbox.Text = string.Empty;
            salary_textbox.Text = string.Empty;
            goods_textbox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e) // income button
        {
            try
            {

                string check = combo_box1.SelectedItem.ToString();

                if (check == "Income")
                {

                    if (List_view.SelectedItems.Count > 0)
                    {
                        var shop = (Shop.Shop)List_view.SelectedItems[0].Tag;

                        if (shop != null && month_textbox.Text != string.Empty)
                        {
                            double month = Convert.ToDouble(month_textbox.Text);
                            double income = shop.Income_Per_Time(month);
                            income_in_time_textbox.Text = income.ToString();
                        }
                    }
                    else
                    {
                        ClearText();
                    }
                }
                else if (check == "Tax")
                {
                    if (List_view.SelectedItems.Count > 0)
                    {
                        var shop = (Shop.Shop)List_view.SelectedItems[0].Tag;

                        if (shop != null && month_textbox.Text != string.Empty)
                        {
                            double percent = Convert.ToDouble(month_textbox.Text);
                            double tax = shop.Annual_Tax(percent);
                            income_in_time_textbox.Text = tax.ToString();
                        }
                    }
                    else
                    {
                        ClearText();
                    }
                }
                else if (check == "Compare")
                {
                    try
                    {
                        Tuple<Shop.Shop, Shop.Shop> shops = GetItemsFromList(month_textbox.Text, income_in_time_textbox.Text);
                        Shop.Shop first_shop = shops.Item1, second_shop = shops.Item2;

                        int result = first_shop.CompareTo(second_shop);
                        if (result == 1)
                        {
                            MessageBox.Show("First shop is bigger");
                        }
                        else if (result == -1)
                        {
                            MessageBox.Show("First shop is smaller");
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("The sizes of the shops are the same");
                        }
                    }
                    catch (InvalidDataException exception)
                    {
                        MessageBox.Show(exception.Message, "Error");
                    }
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private Tuple<Shop.Shop, Shop.Shop> GetItemsFromList(string shop_1, string shop_2)
        {
            ListView.ListViewItemCollection shops = List_view.Items;
            Shop.Shop first_shop = null, second_shop = null;

            foreach (ListViewItem item in shops)
            {
                var shop = item.Tag as Shop.Shop;
                if (shop.Title == shop_1)
                {
                    first_shop = shop;
                }
                else if (shop.Title == shop_2)
                {
                    second_shop = shop;
                }
            }

            if (first_shop == null)
            {
                string exception_message = "There is no shop with title: " + shop_1;
                throw new InvalidDataException(exception_message);
            }
            else if (second_shop == null)
            {
                string exception_message = "There is no shop with title: " + shop_2;
                throw new InvalidDataException(exception_message);
            }

            return new Tuple<Shop.Shop, Shop.Shop>(first_shop, second_shop);
        }

        private void combo_box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check = combo_box1.Text;
            if (check == "Income")
            {
                label9.Text = "Months";
                label10.Text = "Income";
            }
            else if (check == "Tax")
            {
                label9.Text = "Percent";
                label10.Text = "Annual tax";
            }
            else if (check == "Compare")
            {
                label9.Text = "Shop №1";
                label10.Text = "Shop №2";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var current_shop = (Shop.Shop)List_view.SelectedItems[0].Tag;

                Form_worker form_worker = new Form_worker(current_shop);
                form_worker.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var current_shop = (Shop.Shop)List_view.SelectedItems[0].Tag;

                Form_car form_car = new Form_car(current_shop);
                form_car.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void W_List_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (W_List_view.SelectedItems.Count > 0)
            {
                var current_shop = (Worker)W_List_view.SelectedItems[0].Tag;

                Form_selected_worker new_form = new Form_selected_worker(current_shop);
                new_form.ShowDialog();

            }
        }

        private void C_List_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_List_view.SelectedItems.Count > 0)
            {
                var current_shop = (Car)C_List_view.SelectedItems[0].Tag;

                Form_selected_car new_form = new Form_selected_car(current_shop);
                new_form.ShowDialog();

            }
        }

        private async void Load_data_button_Click(object sender, EventArgs e)
        {
            List<Shop.Shop> shops_list = await DeserializeAsync();

            foreach(Shop.Shop item in shops_list)
            {
                ListViewItem Li = new ListViewItem(item.Title);
                Li.Tag = item;
                List_view.Items.Add(Li);
            }
        }

        private async Task<List<Shop.Shop>> DeserializeAsync()
        {
            using (FileStream stream = new FileStream(_pathToShopsDataFile, FileMode.OpenOrCreate))
            {
                List<Shop.Shop> shops_list = await JsonSerializer.DeserializeAsync<List<Shop.Shop>>(stream);

                return shops_list;
            }
        }

        private async void Save_data_button_Click(object sender, EventArgs e)
        {
            var shops_list = new List<Shop.Shop>();

            foreach (ListViewItem item in List_view.Items)
            {
                if (item != null)
                    shops_list.Add((Shop.Shop)item.Tag);
            }

            await SerializeAsync(shops_list);

            UnloadAsync();
        }

        private async Task SerializeAsync(List<Shop.Shop> shops)
        {
            using (var stream = new FileStream(_pathToShopsDataFile, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Shop.Shop>>(stream, shops);
            }
        }

        private async void UnloadAsync()
        {
            var cars = new List<Car>();
            var workers = new List<Worker>();
            foreach (ListViewItem item in List_view.Items)
            {
                var shop = (Shop.Shop)item.Tag;

                foreach (var car in shop.Cars)
                {
                    cars.Add(car);
                }
                foreach (var worker in shop.Workers)
                {
                    workers.Add(worker);
                }
            }

            await SerializeCarsAsync(cars);
            await SerializeWorkersAsync(workers);
        }

        private async Task SerializeCarsAsync(List<Car> cars)
        {
            using (var stream = new FileStream(_pathToCarsDataFile, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Car>>(stream, cars);
            }
        }
        private async Task SerializeWorkersAsync(List<Worker> workers)
        {
            using (var stream = new FileStream(_pathToWorkersDataFile, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Worker>>(stream, workers);
            }
        }
    }
}
