using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    internal class Eletronics : Product
    {
        string _Brand;
        public Eletronics(string name, double price, int quantity,string brand) : base(name, price, quantity)
        {
            _Brand = brand;
        }

        public string Brand { get => _Brand; set => _Brand=value; }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {Quantity} {Brand}");
        }


    }
}
