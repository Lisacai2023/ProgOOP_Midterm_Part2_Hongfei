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

            Clothing tShirt = new Clothing("T-shirt", 19.99, 10, "Medium");
            Groceries banana = new Groceries("Banana", 0.99, 10, "2024-02-10");
            Eletronics smartphone = new Eletronics("Smartphone", 799, 2, "Apple");

            data.Add(tShirt);
            data.Add(banana);
            data.Add(smartphone);


        }

        internal static List<Product> Data { get => data;}

    }//class
}
