namespace ProgOOP_Midterm_Part2_Hongfei
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tetName = new TextBox();
            tetPrice = new TextBox();
            label3 = new Label();
            tetQuantities = new TextBox();
            label4 = new Label();
            tetExpiryDate = new TextBox();
            label5 = new Label();
            tetSize = new TextBox();
            label6 = new Label();
            tetBrand = new TextBox();
            label7 = new Label();
            btnAddNewItem = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 0;
            label1.Text = "Inventory Add";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 76);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // tetName
            // 
            tetName.Location = new Point(178, 73);
            tetName.Name = "tetName";
            tetName.Size = new Size(250, 47);
            tetName.TabIndex = 2;
            // 
            // tetPrice
            // 
            tetPrice.Location = new Point(640, 73);
            tetPrice.Name = "tetPrice";
            tetPrice.Size = new Size(250, 47);
            tetPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 76);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // tetQuantities
            // 
            tetQuantities.Location = new Point(178, 154);
            tetQuantities.Name = "tetQuantities";
            tetQuantities.Size = new Size(250, 47);
            tetQuantities.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 157);
            label4.Name = "label4";
            label4.Size = new Size(136, 41);
            label4.TabIndex = 5;
            label4.Text = "Quatities";
            // 
            // tetExpiryDate
            // 
            tetExpiryDate.Location = new Point(640, 154);
            tetExpiryDate.Name = "tetExpiryDate";
            tetExpiryDate.Size = new Size(250, 47);
            tetExpiryDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 157);
            label5.Name = "label5";
            label5.Size = new Size(159, 41);
            label5.TabIndex = 7;
            label5.Text = "ExpiryDate";
            // 
            // tetSize
            // 
            tetSize.Location = new Point(178, 240);
            tetSize.Name = "tetSize";
            tetSize.Size = new Size(250, 47);
            tetSize.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 243);
            label6.Name = "label6";
            label6.Size = new Size(71, 41);
            label6.TabIndex = 9;
            label6.Text = "Size";
            // 
            // tetBrand
            // 
            tetBrand.Location = new Point(640, 240);
            tetBrand.Name = "tetBrand";
            tetBrand.Size = new Size(250, 47);
            tetBrand.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 243);
            label7.Name = "label7";
            label7.Size = new Size(95, 41);
            label7.TabIndex = 11;
            label7.Text = "Brand";
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new Point(36, 324);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(295, 53);
            btnAddNewItem.TabIndex = 13;
            btnAddNewItem.Text = "Add New Product";
            btnAddNewItem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(36, 397);
            listView1.Name = "listView1";
            listView1.Size = new Size(1066, 498);
            listView1.TabIndex = 14;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 973);
            Controls.Add(listView1);
            Controls.Add(btnAddNewItem);
            Controls.Add(tetBrand);
            Controls.Add(label7);
            Controls.Add(tetSize);
            Controls.Add(label6);
            Controls.Add(tetExpiryDate);
            Controls.Add(label5);
            Controls.Add(tetQuantities);
            Controls.Add(label4);
            Controls.Add(tetPrice);
            Controls.Add(label3);
            Controls.Add(tetName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tetName;
        private TextBox tetPrice;
        private Label label3;
        private TextBox tetQuantities;
        private Label label4;
        private TextBox tetExpiryDate;
        private Label label5;
        private TextBox tetSize;
        private Label label6;
        private TextBox tetBrand;
        private Label label7;
        private Button btnAddNewItem;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}