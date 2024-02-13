using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    abstract class Product
    {
        String _Name;
        double _Price;
        int _Quantity;

        //double _PValue;



        public Product(string name, double price, int quantity)
        {
            _Name=name;
            _Price=price;
            _Quantity=quantity;
            //_PValue=pvalue;

        }

        public string Name { get => _Name; set => _Name=value; }
        public double Price { get => _Price; set => _Price=value; }
        public int Quantity { get => _Quantity; set => _Quantity=value; }
        //public double PValue { get => _PValue; set => _PValue =value; }

        public abstract void DisplayProductInfo();

        //public abstract double GetValue(double price, int quantities);


    }//class
}
