using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_auto_linq
{
    internal class Car
    {

        public string Model { get; set; }
        public int Cost { get; set; }
        public double HorsePower { get; set; }
        // Constructor
        public Car(string model, int cost, double horsePower)
        {
            Model = model;
            Cost = cost;
            HorsePower = horsePower;
        }
        // Methods
        public override string ToString()
        {
            return $"{Model} мощностью {HorsePower} л.с - цена {Cost}";
        }
    }
}
