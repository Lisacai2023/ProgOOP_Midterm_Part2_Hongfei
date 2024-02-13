namespace ProgOOP_Midterm_Part2_Hongfei
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAllProducts = new Button();
            btnElectronics = new Button();
            label2 = new Label();
            btnClothing = new Button();
            btnGroceries = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnAdd = new Button();
            btnRemove = new Button();
            richTextBox1 = new RichTextBox();
            btnDeleteIn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(584, 27);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management";
            // 
            // btnAllProducts
            // 
            btnAllProducts.Location = new Point(30, 134);
            btnAllProducts.Name = "btnAllProducts";
            btnAllProducts.Size = new Size(188, 58);
            btnAllProducts.TabIndex = 1;
            btnAllProducts.Text = "All Product";
            btnAllProducts.UseVisualStyleBackColor = true;
            btnAllProducts.Click += btnAllProducts_Click;
            // 
            // btnElectronics
            // 
            btnElectronics.Location = new Point(224, 134);
            btnElectronics.Name = "btnElectronics";
            btnElectronics.Size = new Size(188, 58);
            btnElectronics.TabIndex = 2;
            btnElectronics.Text = "Electronics";
            btnElectronics.UseVisualStyleBackColor = true;
            btnElectronics.Click += btnElectronics_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(313, 46);
            label2.TabIndex = 3;
            label2.Text = "Search for pruducts\r\n";
            // 
            // btnClothing
            // 
            btnClothing.Location = new Point(418, 134);
            btnClothing.Name = "btnClothing";
            btnClothing.Size = new Size(188, 58);
            btnClothing.TabIndex = 4;
            btnClothing.Text = "Clothing";
            btnClothing.UseVisualStyleBackColor = true;
            // 
            // btnGroceries
            // 
            btnGroceries.Location = new Point(612, 134);
            btnGroceries.Name = "btnGroceries";
            btnGroceries.Size = new Size(188, 58);
            btnGroceries.TabIndex = 5;
            btnGroceries.Text = "Groceries\r\n";
            btnGroceries.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(30, 221);
            listView1.Name = "listView1";
            listView1.Size = new Size(1026, 725);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantities";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ExpiryDate";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Size";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Brand";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Value";
            columnHeader7.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1098, 573);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 58);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(1098, 420);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(188, 58);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1317, 221);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(542, 645);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // btnDeleteIn
            // 
            btnDeleteIn.Location = new Point(1317, 888);
            btnDeleteIn.Name = "btnDeleteIn";
            btnDeleteIn.Size = new Size(260, 58);
            btnDeleteIn.TabIndex = 10;
            btnDeleteIn.Text = "Delete Inventory";
            btnDeleteIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1620, 888);
            button1.Name = "button1";
            button1.Size = new Size(239, 58);
            button1.TabIndex = 11;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1904, 1010);
            Controls.Add(button1);
            Controls.Add(btnDeleteIn);
            Controls.Add(richTextBox1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Controls.Add(btnGroceries);
            Controls.Add(btnClothing);
            Controls.Add(label2);
            Controls.Add(btnElectronics);
            Controls.Add(btnAllProducts);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAllProducts;
        private Button btnElectronics;
        private Label label2;
        private Button btnClothing;
        private Button btnGroceries;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnAdd;
        private Button btnRemove;
        private RichTextBox richTextBox1;
        private Button btnDeleteIn;
        private Button button1;
        private ColumnHeader columnHeader7;
    }
}
