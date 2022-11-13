using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Mobile
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public string Company { get; set; }

        public void GetData(string Name, string Model, int Price, string Company )
        {
            
                Name = Name;
                Model = Model;
                Price = Price;
                Company = Company;

        }
        public void GetData(string Name1, string Model1, int Price1)
        {

            Name = Name1;
            Model = Model1;
            Price = Price1;
            Company = "Samsung";

        }
    }
}
