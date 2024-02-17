using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    internal class Clothing : Product
    {
        string _Size;
        public Clothing(string name, double price, int quantity, string size) : base(name, price, quantity)
        {
            _Size = size;
        }

        public string Size { get => _Size; set => _Size=value; }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {Quantity} {Size}");
        }




    }//class
}
