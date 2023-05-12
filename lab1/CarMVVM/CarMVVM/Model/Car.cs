using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMVVM.Model
{
    internal class Car
    {
        public int ID { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public double Price { get; set; }
        public string Color { get; set; } = string.Empty;
    }
}
