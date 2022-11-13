using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Employee
    {
        public string Name { get; set; }

        public string Department { get; set; }

        private string _designation { get; set; }

        private int _salary;

        public  int Salary 
        { 
            get { return _salary; }
            set
            {
                _salary = value;
            }
        }

        public string Designation
        {
            get 
            { 
                return _designation; 
            }
            set { 
                if (value == "Trainee")
                {
                    _salary = 5000;
                }
                if(value == "Manager")
                {
                    _salary = 20000;
                }
                if(value == "Senior Employee")
                {
                    _salary= 10000;
                }
                _designation= value;
            }
        }
        public void ShowData()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Salary: {Salary}");
        }
        public void GetData()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Department: ");
            Department = Console.ReadLine();
            Console.Write("Designation: ");
            Designation = Console.ReadLine();
        }
    }
}
