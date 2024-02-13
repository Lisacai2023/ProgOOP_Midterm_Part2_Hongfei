namespace ProgOOP_Midterm_Part2_Hongfei
{
    public partial class Form1 : Form
    {
        List<Product> datalist = Inventory.Data;

        Clothing tShirt = new Clothing("T-shirt", 19.99, 10, "Medium");

        Groceries banana = new Groceries("Banana", 0.99, 10, "2024-02-10");

        Eletronics smartphone = new Eletronics("Smartphone", 799, 2, "Apple");

        //public static double GetValue(Groceries banana)
        //{
        //    double PValue = price*quantities;
        //    return PValue;
        //}


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < datalist.Count; i++)
            {
                Product currentItem = datalist[i];

                // Name
                ListViewItem item = new ListViewItem(currentItem.Name);
                // Price
                item.SubItems.Add(currentItem.Price.ToString());
                // Quanity
                item.SubItems.Add(currentItem.Quantity.ToString());
                // Expire
                if (currentItem.GetType() == typeof(Groceries))
                {
                    Groceries grocery = (Groceries)currentItem;
                    item.SubItems.Add(grocery.ExpiryDate);
                }
                else
                {
                    item.SubItems.Add("");
                }

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
                //item.SubItems.Add("");



            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnElectronics_Click(object sender, EventArgs e)
        {

        }
    }//class Form1
}//namespace
