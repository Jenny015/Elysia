namespace Elysia
{
    partial class NewOrder
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.cbPartID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDealerCompany = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblpartName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDealerID
            // 
            this.cbDealerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(122, 158);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(108, 29);
            this.cbDealerID.TabIndex = 4;
            this.cbDealerID.SelectedIndexChanged += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.SelectionChangeCommitted += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.Leave += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            // 
            // cbPartID
            // 
            this.cbPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(325, 52);
            this.cbPartID.Margin = new System.Windows.Forms.Padding(2);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(108, 30);
            this.cbPartID.TabIndex = 5;
            this.cbPartID.SelectedIndexChanged += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            this.cbPartID.SelectionChangeCommitted += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            this.cbPartID.Leave += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(815, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(673, 53);
            this.nQty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.nQty.Size = new System.Drawing.Size(90, 29);
            this.nQty.TabIndex = 8;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.ValueChanged += new System.EventHandler(this.nQty_ValueChanged);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 22;
            this.lbItems.Location = new System.Drawing.Point(23, 54);
            this.lbItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(148, 202);
            this.lbItems.Sorted = true;
            this.lbItems.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDate.Location = new System.Drawing.Point(413, 68);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 21);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "date";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblOrderID.Location = new System.Drawing.Point(117, 68);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(69, 21);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "orderID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(720, 689);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(862, 689);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 29);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDealerCompany
            // 
            this.lblDealerCompany.AutoSize = true;
            this.lblDealerCompany.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDealerCompany.Location = new System.Drawing.Point(741, 160);
            this.lblDealerCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerCompany.Name = "lblDealerCompany";
            this.lblDealerCompany.Size = new System.Drawing.Size(41, 21);
            this.lblDealerCompany.TabIndex = 14;
            this.lblDealerCompany.Text = "N/A";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDealerName.Location = new System.Drawing.Point(429, 160);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(41, 21);
            this.lblDealerName.TabIndex = 15;
            this.lblDealerName.Text = "N/A";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteItem.Location = new System.Drawing.Point(211, 235);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteItem.TabIndex = 16;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dealer ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(303, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDealerCompany);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDealerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDealerID);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(23, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(938, 233);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(577, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dealer Company: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(303, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dealer Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.lblpartName);
            this.groupBox2.Controls.Add(this.label11);
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
            this.groupBox2.Location = new System.Drawing.Point(23, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(938, 289);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product and Quantity";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblStock.Location = new System.Drawing.Point(673, 126);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 21);
            this.lblStock.TabIndex = 27;
            this.lblStock.Text = "N/A";
            // 
            // lblpartName
            // 
            this.lblpartName.AutoSize = true;
            this.lblpartName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblpartName.Location = new System.Drawing.Point(354, 126);
            this.lblpartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpartName.Name = "lblpartName";
            this.lblpartName.Size = new System.Drawing.Size(41, 21);
            this.lblpartName.TabIndex = 22;
            this.lblpartName.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(577, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Stocking: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(212, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Product Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select the item in the list to delete it.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(577, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(212, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product ID: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 65);
            this.panel2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "NewOrder";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewOrder";
            this.Size = new System.Drawing.Size(1002, 762);
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDealerID;
        private System.Windows.Forms.ComboBox cbPartID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDealerCompany;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblpartName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

