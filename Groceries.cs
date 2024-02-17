using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    internal class Groceries : Product
    {
        string _ExpiryDate;

        public Groceries(string name, double price, int quantity, string expiryDate) : base(name, price, quantity)
        {
            _ExpiryDate = expiryDate;
        }

        public string ExpiryDate { get => _ExpiryDate; set => _ExpiryDate=value; }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {Quantity} {ExpiryDate}");
        }





    }//Class
}
