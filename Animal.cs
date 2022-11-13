using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Animal
    {
        public string Name { get; set; }

        public int MaxLifeTime { get; set; }

        public string Food { get; set; }

        public Animal(string n, int l, string f) 
        { 
            Name = n;
            MaxLifeTime = l;
            Food = f;
        }
    }
}
