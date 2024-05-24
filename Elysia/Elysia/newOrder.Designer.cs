namespace Elysia
{
    partial class newOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblDealerID = new System.Windows.Forms.Label();
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.cbPartID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDealerCompany = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel1.Size = new System.Drawing.Size(280, 762);
            this.panel1.TabIndex = 2;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.Location = new System.Drawing.Point(3, 714);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(272, 43);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Logout";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.Location = new System.Drawing.Point(3, 359);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(272, 54);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "View Order";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.Location = new System.Drawing.Point(3, 305);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(272, 54);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "New Order";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Location = new System.Drawing.Point(3, 251);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(272, 54);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View Dealer";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(3, 197);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(272, 54);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New Dealer";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(3, 143);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(272, 54);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Sales Department";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(272, 140);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblDealerID
            // 
            this.lblDealerID.AutoSize = true;
            this.lblDealerID.Location = new System.Drawing.Point(309, 166);
            this.lblDealerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerID.Name = "lblDealerID";
            this.lblDealerID.Size = new System.Drawing.Size(49, 13);
            this.lblDealerID.TabIndex = 3;
            this.lblDealerID.Text = "DealerID";
            // 
            // cbDealerID
            // 
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(396, 159);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(82, 21);
            this.cbDealerID.TabIndex = 4;
            this.cbDealerID.SelectedIndexChanged += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.SelectionChangeCommitted += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.Leave += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            // 
            // cbPartID
            // 
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(504, 323);
            this.cbPartID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(82, 21);
            this.cbPartID.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(826, 320);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 20);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(309, 284);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 13);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "Items";
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(670, 322);
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
            this.nQty.Size = new System.Drawing.Size(90, 20);
            this.nQty.TabIndex = 8;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(311, 310);
            this.lbItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(148, 160);
            this.lbItems.Sorted = true;
            this.lbItems.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(537, 100);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(28, 13);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "date";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(394, 100);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(42, 13);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "orderID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(597, 669);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 20);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(704, 669);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 20);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDealerCompany
            // 
            this.lblDealerCompany.AutoSize = true;
            this.lblDealerCompany.Location = new System.Drawing.Point(530, 207);
            this.lblDealerCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerCompany.Name = "lblDealerCompany";
            this.lblDealerCompany.Size = new System.Drawing.Size(0, 13);
            this.lblDealerCompany.TabIndex = 14;
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(530, 162);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(0, 13);
            this.lblDealerName.TabIndex = 15;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(340, 484);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(81, 20);
            this.btnDeleteItem.TabIndex = 16;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // newOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 762);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblDealerName);
            this.Controls.Add(this.lblDealerCompany);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.nQty);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbPartID);
            this.Controls.Add(this.cbDealerID);
            this.Controls.Add(this.lblDealerID);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newOrder";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblDealerID;
        private System.Windows.Forms.ComboBox cbDealerID;
        private System.Windows.Forms.ComboBox cbPartID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDealerCompany;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}

