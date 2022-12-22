using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_LB2.Shop
{
    public class Worker
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (true)
                {
                    name = value;
                }
                
            }
        }

        string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (true)
                {
                    surname = value;
                }
                
            }
        }

        string education;
        public string Education
        {
            get { return education; }
            set
            {
                if (true)
                {
                    education = value;
                }
                
            }
        }

        string position;
        public string Position
        {
            get { return position; }
            set
            {
                if (true)
                {
                    position = value;
                }
                
            }
        }

        double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (true)
                {
                    salary = value;
                }
                
            }
        }

        public Worker()
        {

        }

        public Worker(string w_name, string w_surname, string w_education, string w_position, double w_salary)
        {
            Name = w_name;
            Surname = w_surname;
            Education = w_education;
            Position = w_position;
            Salary = w_salary;
        }
    }
}
