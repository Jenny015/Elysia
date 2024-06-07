namespace Elysia
{
    partial class NewGoodsInward
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSComp = new System.Windows.Forms.Label();
            this.lblInwardsID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpartName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.cbPartID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(1149, 802);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 33);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.submitForm);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(960, 802);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 33);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSComp);
            this.groupBox1.Controls.Add(this.lblInwardsID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSupplierID);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(31, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1251, 269);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(462, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Supplier Company: ";
            // 
            // lblSComp
            // 
            this.lblSComp.AutoSize = true;
            this.lblSComp.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblSComp.Location = new System.Drawing.Point(695, 179);
            this.lblSComp.Name = "lblSComp";
            this.lblSComp.Size = new System.Drawing.Size(53, 27);
            this.lblSComp.TabIndex = 14;
            this.lblSComp.Text = "N/A";
            // 
            // lblInwardsID
            // 
            this.lblInwardsID.AutoSize = true;
            this.lblInwardsID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblInwardsID.Location = new System.Drawing.Point(178, 82);
            this.lblInwardsID.Name = "lblInwardsID";
            this.lblInwardsID.Size = new System.Drawing.Size(112, 27);
            this.lblInwardsID.TabIndex = 11;
            this.lblInwardsID.Text = "inwardsID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(462, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inwards Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inwards ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Supplier ID: ";
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(183, 178);
            this.cbSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(182, 34);
            this.cbSupplierID.TabIndex = 4;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            this.cbSupplierID.Leave += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDate.Location = new System.Drawing.Point(629, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 27);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblpartName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbItems);
            this.groupBox2.Controls.Add(this.btnDeleteItem);
            this.groupBox2.Controls.Add(this.cbPartID);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.nQty);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(31, 431);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1251, 333);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inward Parts";
            // 
            // lblpartName
            // 
            this.lblpartName.AutoSize = true;
            this.lblpartName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblpartName.Location = new System.Drawing.Point(462, 142);
            this.lblpartName.Name = "lblpartName";
            this.lblpartName.Size = new System.Drawing.Size(53, 27);
            this.lblpartName.TabIndex = 22;
            this.lblpartName.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(283, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Product Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(284, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select the item in the list to delete it.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(770, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(283, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product ID: ";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 25;
            this.lbItems.Location = new System.Drawing.Point(31, 62);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(196, 229);
            this.lbItems.Sorted = true;
            this.lbItems.TabIndex = 9;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteItem.Location = new System.Drawing.Point(282, 271);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(133, 33);
            this.btnDeleteItem.TabIndex = 16;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // cbPartID
            // 
            this.cbPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(433, 60);
            this.cbPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(143, 33);
            this.cbPartID.TabIndex = 5;
            this.cbPartID.SelectedIndexChanged += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            this.cbPartID.Leave += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(1087, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(898, 61);
            this.nQty.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(120, 34);
            this.nQty.TabIndex = 8;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 75);
            this.panel2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "GoodInward";
            // 
            // NewGoodsInward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewGoodsInward";
            this.Size = new System.Drawing.Size(1336, 879);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSComp;
        private System.Windows.Forms.Label lblInwardsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblpartName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ComboBox cbPartID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}