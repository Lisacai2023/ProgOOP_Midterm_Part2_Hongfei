using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    internal class Groceries : Product
    {
        string _ExpiryDate;

        public Groceries(string name, double price, int quantity, string expiryDate) : base(name, price, quantity)
        {
            _ExpiryDate = expiryDate;
        }

        //public Groceries(string name, double price, int quantity, string expiryDate, double pvalue) : base(name, price, quantity,pvalue)
        //{
        //    _ExpiryDate = expiryDate;
        //}




        public string ExpiryDate { get => _ExpiryDate; set => _ExpiryDate=value; }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {Quantity} {ExpiryDate}");
        }

        //public override double GetValue(double price, int quantities)
        //{
        //    double PValue = price*quantities;
        //    return PValue;
        //}


    }//Class
}
