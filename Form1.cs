using System.Runtime;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    public partial class Form1 : Form
    {
        List<Product> datalist = Inventory.Data;

        Clothing tShirt = new Clothing("T-shirt", 19.9, 10, "Medium");

        Groceries banana = new Groceries("Banana", 0.9, 10, "2024-02-10");

        Eletronics smartphone = new Eletronics("Smartphone", 799, 2, "Apple");


        public Form1()
        {
            InitializeComponent();


        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            // Clear the listview
            listView1.Items.Clear();

            // Loop through our list
            for (int i = 0; i < datalist.Count; i++)
            {
                // 
                Product currentItem = datalist[i];


                // A new list view item
                // Name
                ListViewItem item = new ListViewItem(currentItem.Name);
                // Price
                item.SubItems.Add(currentItem.Price.ToString());
                // Quanity
                item.SubItems.Add(currentItem.Quantity.ToString());
                // Expire
                // If Grocery - Display Expiry
                if (currentItem.GetType() == typeof(Groceries))
                {
                    //casting
                    Groceries grocery = (Groceries)currentItem;
                    item.SubItems.Add(grocery.ExpiryDate);
                }
                else
                {
                    item.SubItems.Add("");
                }
                // If Clothing - display size
                // Size
                if (currentItem.GetType()== typeof(Clothing))
                {
                    Clothing clothing = (Clothing)currentItem;
                    item.SubItems.Add(clothing.Size);
                }
                else
                {
                    item.SubItems.Add("");
                }

                // If electronics, ,dispaly brand
                // Brand
                if (currentItem.GetType() == typeof(Eletronics))
                {
                    Eletronics eletronics = (Eletronics)currentItem;
                    item.SubItems.Add(eletronics.Brand);
                }
                else
                {
                    item.SubItems.Add("");
                }

                // Value
                double Pvalue = currentItem.Price * currentItem.Quantity;
                item.SubItems.Add(Pvalue.ToString("0.00"));

                listView1.Items.Add(item);



            }


        }//All products

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnElectronics_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            for (int i = 0; i <  datalist.Count; i++)
            {
                Product currentItem = datalist[i];
                if (currentItem.GetType()== typeof(Eletronics))
                {
                    Eletronics eletronics = (Eletronics)currentItem;
                    ListViewItem item = new ListViewItem(eletronics.Name);
                    item.SubItems.Add(eletronics.Price.ToString());
                    item.SubItems.Add(eletronics.Quantity.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add(eletronics.Brand);
                    double Pvalue = eletronics.Price* eletronics.Quantity;
                    item.SubItems.Add(Pvalue.ToString());
                    listView1.Items.Add(item);

                }

            }

        }//Electronics

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            for (int i = 0; i <  datalist.Count; i++)
            {
                Product currentItem = datalist[i];
                if (currentItem.GetType()== typeof(Clothing))
                {
                    Clothing clothing = (Clothing)currentItem;
                    ListViewItem item = new ListViewItem(clothing.Name);
                    item.SubItems.Add(clothing.Price.ToString());
                    item.SubItems.Add(clothing.Quantity.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add(clothing.Size);
                    item.SubItems.Add("");
                    double Pvalue = clothing.Price* clothing.Quantity;
                    item.SubItems.Add(Pvalue.ToString());
                    listView1.Items.Add(item);

                }

            }

        }//Clothing

        private void btnGroceries_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            for (int i = 0; i < datalist.Count; i++)
            {
                Product currentItem = datalist[i];
                if (currentItem.GetType()== typeof(Groceries))
                {
                    Groceries groceries = (Groceries)currentItem;
                    ListViewItem item = new ListViewItem(groceries.Name);
                    item.SubItems.Add(groceries.Price.ToString());
                    item.SubItems.Add(groceries.Quantity.ToString());
                    item.SubItems.Add(groceries.ExpiryDate);
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    double Pvalue = groceries.Price* groceries.Quantity;
                    item.SubItems.Add(Pvalue.ToString("0.00"));
                    listView1.Items.Add(item);

                }

            }


        }//Groceries

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string itemText = selectedItem.Text;
                richTextBox1.AppendText(itemText + Environment.NewLine);
            }



        }
    }//class Form1


}//namespace
