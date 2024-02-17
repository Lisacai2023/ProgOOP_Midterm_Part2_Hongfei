using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            tetName.Text = "";
            tetPrice.Text = "";
            tetExpiryDate.Text="";
            tetQuantities.Text = "";
            tetSize.Text = "";
            tetBrand.Text = "";

        }


    }
}
