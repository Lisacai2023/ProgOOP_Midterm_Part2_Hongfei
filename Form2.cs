using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgOOP_Midterm_Part2_Hongfei
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {

            List<Product> addNewdatalist = Inventory.Data;

            ////Old version
            ListViewItem Additem = new ListViewItem(tetName.Text);
            Additem.SubItems.Add(tetPrice.Text);
            Additem.SubItems.Add(tetQuantities.Text);
            Additem.SubItems.Add(tetExpiryDate.Text);
            Additem.SubItems.Add(tetSize.Text);
            Additem.SubItems.Add(tetBrand.Text);

            double newPrice = double.Parse(tetPrice.Text);
            int newQuantities = int.Parse(tetQuantities.Text);
            double newValue = newPrice * newQuantities;
            Additem.SubItems.Add(newValue.ToString());
            listView2.Items.Add(Additem);

            //2-17 update synchronized function in two listview
            //Add new item to Groceries,Eletronics,Clothing
            Groceries addnewGroceries = new Groceries(tetName.Text,double.Parse(tetPrice.Text),int.Parse(tetQuantities.Text),tetExpiryDate.Text);
            Inventory.Data.Add(addnewGroceries);
            Eletronics addnewEletronics = new Eletronics(tetName.Text, double.Parse(tetPrice.Text), int.Parse(tetQuantities.Text), tetBrand.Text);
            Inventory.Data.Add(addnewEletronics);
            Clothing addnewClothing = new Clothing(tetName.Text, double.Parse(tetPrice.Text), int.Parse(tetQuantities.Text), tetSize.Text);
            Inventory.Data.Add(addnewClothing);

            //List<Product> datalist = Inventory.Data;
            //Product currentItem = datalist[0];

            //if (currentItem.GetType()== typeof(Eletronics))
            //{
            //    //Eletronics eletronics = (Eletronics)currentItem;
            //    ListViewItem item = new ListViewItem(addnewEletronics.Name);
            //    item.SubItems.Add(addnewEletronics.Price.ToString());
            //    item.SubItems.Add(addnewEletronics.Quantity.ToString());
            //    item.SubItems.Add("");
            //    item.SubItems.Add("");
            //    item.SubItems.Add(addnewEletronics.Brand);
            //    double Pvalue = addnewEletronics.Price* addnewEletronics.Quantity;
            //    item.SubItems.Add(Pvalue.ToString());
            //    listView2.Items.Add(item);

            //}
            //else if (currentItem.GetType()== typeof(Groceries))
            //{
            //    ListViewItem item = new ListViewItem(addnewGroceries.Name);
            //    item.SubItems.Add(addnewGroceries.Price.ToString());
            //    item.SubItems.Add(addnewGroceries.Quantity.ToString());
            //    item.SubItems.Add(addnewGroceries.ExpiryDate);
            //    item.SubItems.Add("");
            //    item.SubItems.Add("");
            //    double Pvalue = addnewGroceries.Price*  addnewGroceries.Quantity;
            //    item.SubItems.Add(Pvalue.ToString());
            //    listView2.Items.Add(item);

            //}
            //else if (currentItem.GetType()== typeof(Clothing))
            //{
            //    ListViewItem item = new ListViewItem(addnewClothing.Name);
            //    item.SubItems.Add(addnewClothing.Price.ToString());
            //    item.SubItems.Add(addnewClothing.Quantity.ToString());
            //    item.SubItems.Add("");
            //    item.SubItems.Add(addnewClothing.Size);
            //    item.SubItems.Add("");
            //    double Pvalue = addnewClothing.Price* addnewClothing.Quantity;
            //    item.SubItems.Add(Pvalue.ToString());
            //    listView2.Items.Add(item);

            //}


            //old editing 
            //ListViewItem Additem = new ListViewItem(addnewGroceries.Name);
            //Additem.SubItems.Add(addnewGroceries.Price.ToString());
            //Additem.SubItems.Add(addnewGroceries.Quantity.ToString());
            //Additem.SubItems.Add(addnewGroceries.ExpiryDate);
            //Additem.SubItems.Add("");
            //Additem.SubItems.Add("");
            //double PvalueG = addnewGroceries.Price * addnewGroceries.Quantity;
            //Additem.SubItems.Add(PvalueG.ToString("0.00"));
            //listView2.Items.Add(Additem);

            tetName.Text = "";
            tetPrice.Text = "";
            tetExpiryDate.Text="";
            tetQuantities.Text = "";
            tetSize.Text = "";
            tetBrand.Text = "";





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }

        }
    }
}
