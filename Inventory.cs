using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    public static class Inventory
    {
        static List<Product> data;

        static Inventory()
        {
            data = new List<Product>();

            Clothing tShirt = new Clothing("T-shirt", 19.9, 10, "Medium");
            Clothing tShirtS = new Clothing("T-shirt", 19.9, 10, "Small");
            Clothing cPant = new Clothing("Pant", 29.9, 10, "Large");

            Groceries banana = new Groceries("Banana", 0.9, 10, "2024-02-10");
            Groceries apple = new Groceries("Apple", 1.29, 30, "2024-03-20");
            Groceries orange = new Groceries("Orange", 2.49, 50, "2024-05-10");

            Eletronics smartphone = new Eletronics("Smartphone", 1099, 2, "Apple");
            Eletronics ipad = new Eletronics("ipad", 799, 2, "Apple");
            Eletronics watch = new Eletronics("Watch", 399, 2, "Apple");

            data.Add(tShirt);
            data.Add(tShirtS);
            data.Add(cPant);

            data.Add(banana);
            data.Add(apple);
            data.Add(orange);

            data.Add(smartphone);
            data.Add(ipad);
            data.Add(watch);
        }

        internal static List<Product> Data { get => data;}

    }//class
}
