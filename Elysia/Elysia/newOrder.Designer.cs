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
            this.btnLogout = new System.Windows.Forms.RadioButton();
            this.btnViewOrder = new System.Windows.Forms.RadioButton();
            this.btnNewOrder = new System.Windows.Forms.RadioButton();
            this.btnViewDealer = new System.Windows.Forms.RadioButton();
            this.btnNewDealer = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.btnNewOrder);
            this.panel1.Controls.Add(this.btnViewDealer);
            this.panel1.Controls.Add(this.btnNewDealer);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(419, 1055);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(4, 990);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(409, 59);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrder.Location = new System.Drawing.Point(4, 498);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(409, 75);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.TabStop = true;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewOrder.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOrder.Location = new System.Drawing.Point(4, 423);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(409, 75);
            this.btnNewOrder.TabIndex = 4;
            this.btnNewOrder.TabStop = true;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnViewDealer
            // 
            this.btnViewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDealer.Location = new System.Drawing.Point(4, 348);
            this.btnViewDealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewDealer.Name = "btnViewDealer";
            this.btnViewDealer.Size = new System.Drawing.Size(409, 75);
            this.btnViewDealer.TabIndex = 3;
            this.btnViewDealer.TabStop = true;
            this.btnViewDealer.Text = "View Dealer";
            this.btnViewDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDealer.UseVisualStyleBackColor = false;
            // 
            // btnNewDealer
            // 
            this.btnNewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnNewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDealer.Location = new System.Drawing.Point(4, 273);
            this.btnNewDealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(409, 75);
            this.btnNewDealer.TabIndex = 2;
            this.btnNewDealer.TabStop = true;
            this.btnNewDealer.Text = "New Dealer";
            this.btnNewDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewDealer.UseVisualStyleBackColor = false;
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(4, 198);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(409, 75);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Sales Department";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(4, 4);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(409, 194);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // cbDealerID
            // 
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(183, 219);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(160, 41);
            this.cbDealerID.TabIndex = 4;
            this.cbDealerID.SelectedIndexChanged += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.SelectionChangeCommitted += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            this.cbDealerID.Leave += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
            // 
            // cbPartID
            // 
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(487, 72);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(160, 40);
            this.cbPartID.TabIndex = 5;
            this.cbPartID.SelectedIndexChanged += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            this.cbPartID.SelectionChangeCommitted += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            this.cbPartID.Leave += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(1223, 73);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(1010, 73);
            this.nQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.nQty.Size = new System.Drawing.Size(135, 40);
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
            this.lbItems.ItemHeight = 32;
            this.lbItems.Location = new System.Drawing.Point(35, 75);
            this.lbItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(220, 292);
            this.lbItems.Sorted = true;
            this.lbItems.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDate.Location = new System.Drawing.Point(631, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 33);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "date";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblOrderID.Location = new System.Drawing.Point(175, 94);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(101, 33);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "orderID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1511, 945);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 41);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(1723, 945);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 41);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDealerCompany
            // 
            this.lblDealerCompany.AutoSize = true;
            this.lblDealerCompany.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDealerCompany.Location = new System.Drawing.Point(1112, 222);
            this.lblDealerCompany.Name = "lblDealerCompany";
            this.lblDealerCompany.Size = new System.Drawing.Size(62, 33);
            this.lblDealerCompany.TabIndex = 14;
            this.lblDealerCompany.Text = "N/A";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblDealerName.Location = new System.Drawing.Point(655, 222);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(62, 33);
            this.lblDealerName.TabIndex = 15;
            this.lblDealerName.Text = "N/A";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteItem.Location = new System.Drawing.Point(317, 325);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(150, 41);
            this.btnDeleteItem.TabIndex = 16;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dealer ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(467, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Order Form";
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
            this.groupBox1.Location = new System.Drawing.Point(466, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1407, 323);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(866, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dealer Company: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(467, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(466, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1407, 401);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product and Quantity";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblStock.Location = new System.Drawing.Point(1006, 171);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 33);
            this.lblStock.TabIndex = 27;
            this.lblStock.Text = "N/A";
            // 
            // lblpartName
            // 
            this.lblpartName.AutoSize = true;
            this.lblpartName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblpartName.Location = new System.Drawing.Point(525, 171);
            this.lblpartName.Name = "lblpartName";
            this.lblpartName.Size = new System.Drawing.Size(62, 33);
            this.lblpartName.TabIndex = 22;
            this.lblpartName.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(866, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "Stocking: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(318, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Product Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select the item in the list to delete it.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(866, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(318, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product ID: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 90);
            this.panel2.TabIndex = 23;
            // 
            // newOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1923, 1055);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "newOrder";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.RadioButton btnViewOrder;
        private System.Windows.Forms.RadioButton btnNewOrder;
        private System.Windows.Forms.RadioButton btnViewDealer;
        private System.Windows.Forms.RadioButton btnNewDealer;
        public System.Windows.Forms.PictureBox imgLogo;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblpartName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

