using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_LB2.Shop
{
    public class Car
    {
        string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (true)
                {
                    brand = value;
                }
                
            }
        }

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (true)
                {
                    title = value;
                }
                
            }
        }

        string control;
        public string Control
        {
            get { return control; }
            set
            {
                if (true)
                {
                    control = value;
                }
                
            }
        }

        string fuel;
        public string Fuel
        {
            get { return fuel; }
            set
            {
                if (true)
                {
                    fuel = value;
                }
                
            }
        }

        double engine_capacity;
        public double Engine_Capacity
        {
            get { return engine_capacity; }
            set
            {
                if (true)
                {
                    engine_capacity = value;
                }
                
            }
        }

        double fuel_consumption;
        public double Fuel_Consumption
        {
            get { return fuel_consumption; }
            set
            {
                if (true)
                {
                    fuel_consumption = value;
                }
                
            }
        }

        double cost_for_shop;
        public double Cost_For_Shop
        {
            get { return cost_for_shop; }
            set
            {
                if (true)
                {
                    cost_for_shop = value;
                }
                
            }
        }

        double cost_for_customer;
        public double Cost_For_Customer
        {
            get { return cost_for_customer; }
            set
            {
                if (true)
                {
                    cost_for_customer = value;
                }
                
            }
        }

        public Car()
        {

        }

        public Car(string c_brand, string c_title, string c_control, string c_fuel, double c_capacity, double c_consumption, double c_costshop, double c_costcustomer)
        {
            Brand = c_brand;
            Title = c_title;
            Control = c_control;
            Fuel = c_fuel;
            Engine_Capacity = c_capacity;
            Fuel_Consumption = c_consumption;
            Cost_For_Shop = c_costshop;
            Cost_For_Customer = c_costcustomer;
        }
    }
}
