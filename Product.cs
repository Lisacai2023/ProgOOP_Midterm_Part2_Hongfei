using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    public abstract class Product
    {
        String _Name;
        double _Price;
        int _Quantity;

        public Product(string name, double price, int quantity)
        {
            _Name=name;
            _Price=price;
            _Quantity=quantity;

        }

        public string Name { get => _Name; set => _Name=value; }
        public double Price { get => _Price; set => _Price=value; }
        public int Quantity { get => _Quantity; set => _Quantity=value; }


        public abstract void DisplayProductInfo();



    }//class
}
