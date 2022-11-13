using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Food
    {
        public string Name { get; set; }

        private double _price;
        private double _discount;

        public double Price
        {
            get { 
                return _price;
            } 
            set { 
                if (value>150)
                {
                    _discount = 10;
                    value = value - ((value * 10)/100);
                }
                _price = value;
            }
        }

        public double Discount
        {
            get { return _discount; }
            set
            {
                _discount = value;
            }
        }
    }
}
