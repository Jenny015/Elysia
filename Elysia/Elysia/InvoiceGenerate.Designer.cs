namespace Elysia
{
    partial class InvoiceGenerate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblDPhone = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.BAddr = new System.Windows.Forms.Label();
            this.lblDCom = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.Bemail = new System.Windows.Forms.Label();
            this.Btel = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.Label();
            this.BDAddr = new System.Windows.Forms.Label();
            this.BDPhone = new System.Windows.Forms.Label();
            this.BDName = new System.Windows.Forms.Label();
            this.BOrderDate = new System.Windows.Forms.Label();
            this.BDCom = new System.Windows.Forms.Label();
            this.BOrderID = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.Bsign = new System.Windows.Forms.Label();
            this.BPrice = new System.Windows.Forms.Label();
            this.BItems = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLateDelivery = new System.Windows.Forms.RadioButton();
            this.btnInvGen = new System.Windows.Forms.RadioButton();
            this.btnViewInvoice = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.InvPreview = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.bar.SuspendLayout();
            this.InvPreview.SuspendLayout();
            this.heading.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.Location = new System.Drawing.Point(426, 106);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(1482, 775);
            this.dgvOrder.TabIndex = 32;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1756, 895);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 41);
            this.btnFilter.TabIndex = 33;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.email.Location = new System.Drawing.Point(1125, 132);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(172, 22);
            this.email.TabIndex = 39;
            this.email.Text = "salesoffice@lm.com";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tel.Location = new System.Drawing.Point(1125, 100);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(90, 22);
            this.tel.TabIndex = 38;
            this.tel.Text = "22332323";
            // 
            // lblAddr
            // 
            this.lblAddr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblAddr.Location = new System.Drawing.Point(176, 106);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(597, 47);
            this.lblAddr.TabIndex = 37;
            this.lblAddr.Text = "label18";
            // 
            // lblDPhone
            // 
            this.lblDPhone.AutoSize = true;
            this.lblDPhone.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDPhone.Location = new System.Drawing.Point(507, 72);
            this.lblDPhone.Name = "lblDPhone";
            this.lblDPhone.Size = new System.Drawing.Size(70, 22);
            this.lblDPhone.TabIndex = 36;
            this.lblDPhone.Text = "label18";
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDName.Location = new System.Drawing.Point(176, 72);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(70, 22);
            this.lblDName.TabIndex = 35;
            this.lblDName.Text = "label18";
            // 
            // BAddr
            // 
            this.BAddr.AutoSize = true;
            this.BAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BAddr.Location = new System.Drawing.Point(992, 6);
            this.BAddr.Name = "BAddr";
            this.BAddr.Size = new System.Drawing.Size(90, 23);
            this.BAddr.TabIndex = 34;
            this.BAddr.Text = "Address: ";
            // 
            // lblDCom
            // 
            this.lblDCom.AutoSize = true;
            this.lblDCom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDCom.Location = new System.Drawing.Point(176, 38);
            this.lblDCom.Name = "lblDCom";
            this.lblDCom.Size = new System.Drawing.Size(70, 22);
            this.lblDCom.TabIndex = 33;
            this.lblDCom.Text = "label18";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(507, 5);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(70, 22);
            this.lblOrderDate.TabIndex = 31;
            this.lblOrderDate.Text = "label18";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderID.Location = new System.Drawing.Point(176, 5);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 22);
            this.lblOrderID.TabIndex = 30;
            this.lblOrderID.Text = "label18";
            // 
            // Bemail
            // 
            this.Bemail.AutoSize = true;
            this.Bemail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Bemail.Location = new System.Drawing.Point(992, 130);
            this.Bemail.Name = "Bemail";
            this.Bemail.Size = new System.Drawing.Size(70, 23);
            this.Bemail.TabIndex = 29;
            this.Bemail.Text = "Email: ";
            // 
            // Btel
            // 
            this.Btel.AutoSize = true;
            this.Btel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Btel.Location = new System.Drawing.Point(992, 96);
            this.Btel.Name = "Btel";
            this.Btel.Size = new System.Drawing.Size(48, 23);
            this.Btel.TabIndex = 28;
            this.Btel.Text = "Tel: ";
            // 
            // addr
            // 
            this.addr.AutoSize = true;
            this.addr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.addr.Location = new System.Drawing.Point(1125, 6);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(324, 88);
            this.addr.TabIndex = 27;
            this.addr.Text = "12/F, Tower 1,\r\nPhase 1 - Enterprise Square One,\r\nEnterprise Square, 9 Sheung Yue" +
    "t Road,\r\nKOWLOON BAY, KOWLOON";
            // 
            // BDAddr
            // 
            this.BDAddr.AutoSize = true;
            this.BDAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDAddr.Location = new System.Drawing.Point(15, 103);
            this.BDAddr.Name = "BDAddr";
            this.BDAddr.Size = new System.Drawing.Size(166, 23);
            this.BDAddr.TabIndex = 26;
            this.BDAddr.Text = "Delivery Address: ";
            // 
            // BDPhone
            // 
            this.BDPhone.AutoSize = true;
            this.BDPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDPhone.Location = new System.Drawing.Point(376, 70);
            this.BDPhone.Name = "BDPhone";
            this.BDPhone.Size = new System.Drawing.Size(136, 23);
            this.BDPhone.TabIndex = 25;
            this.BDPhone.Text = "Dealer Phone: ";
            // 
            // BDName
            // 
            this.BDName.AutoSize = true;
            this.BDName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDName.Location = new System.Drawing.Point(15, 70);
            this.BDName.Name = "BDName";
            this.BDName.Size = new System.Drawing.Size(133, 23);
            this.BDName.TabIndex = 23;
            this.BDName.Text = "Dealer Name: ";
            // 
            // BOrderDate
            // 
            this.BOrderDate.AutoSize = true;
            this.BOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderDate.Location = new System.Drawing.Point(376, 4);
            this.BOrderDate.Name = "BOrderDate";
            this.BOrderDate.Size = new System.Drawing.Size(120, 23);
            this.BOrderDate.TabIndex = 22;
            this.BOrderDate.Text = "Order Date: ";
            // 
            // BDCom
            // 
            this.BDCom.AutoSize = true;
            this.BDCom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDCom.Location = new System.Drawing.Point(15, 37);
            this.BDCom.Name = "BDCom";
            this.BDCom.Size = new System.Drawing.Size(163, 23);
            this.BDCom.TabIndex = 21;
            this.BDCom.Text = "Dealer Company: ";
            // 
            // BOrderID
            // 
            this.BOrderID.AutoSize = true;
            this.BOrderID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderID.Location = new System.Drawing.Point(15, 5);
            this.BOrderID.Name = "BOrderID";
            this.BOrderID.Size = new System.Drawing.Size(100, 23);
            this.BOrderID.TabIndex = 20;
            this.BOrderID.Text = "Order ID: ";
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.compName.Location = new System.Drawing.Point(431, 18);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(552, 32);
            this.compName.TabIndex = 1;
            this.compName.Text = "Legend Motor (LC) Limited Company";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 168);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(1448, 430);
            this.dgv.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPrice.Location = new System.Drawing.Point(371, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 22);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "label18";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblItems.Location = new System.Drawing.Point(136, 18);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(70, 22);
            this.lblItems.TabIndex = 38;
            this.lblItems.Text = "label18";
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.sign.Location = new System.Drawing.Point(1186, 65);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(252, 26);
            this.sign.TabIndex = 33;
            this.sign.Text = "____________________";
            // 
            // Bsign
            // 
            this.Bsign.AutoSize = true;
            this.Bsign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Bsign.Location = new System.Drawing.Point(1066, 49);
            this.Bsign.Name = "Bsign";
            this.Bsign.Size = new System.Drawing.Size(126, 26);
            this.Bsign.TabIndex = 32;
            this.Bsign.Text = "Signature: ";
            // 
            // BPrice
            // 
            this.BPrice.AutoSize = true;
            this.BPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BPrice.Location = new System.Drawing.Point(263, 17);
            this.BPrice.Name = "BPrice";
            this.BPrice.Size = new System.Drawing.Size(114, 23);
            this.BPrice.TabIndex = 31;
            this.BPrice.Text = "Total Price: ";
            // 
            // BItems
            // 
            this.BItems.AutoSize = true;
            this.BItems.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BItems.Location = new System.Drawing.Point(10, 17);
            this.BItems.Name = "BItems";
            this.BItems.Size = new System.Drawing.Size(117, 23);
            this.BItems.TabIndex = 30;
            this.BItems.Text = "Total Items: ";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Plum;
            this.btnPDF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPDF.Location = new System.Drawing.Point(1590, 895);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(150, 41);
            this.btnPDF.TabIndex = 35;
            this.btnPDF.Text = "Save as PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Visible = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1758, 895);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 41);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLateDelivery);
            this.panel1.Controls.Add(this.btnInvGen);
            this.panel1.Controls.Add(this.btnViewInvoice);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(419, 949);
            this.panel1.TabIndex = 45;
            // 
            // btnLateDelivery
            // 
            this.btnLateDelivery.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLateDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLateDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLateDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLateDelivery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLateDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateDelivery.Location = new System.Drawing.Point(4, 494);
            this.btnLateDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLateDelivery.Name = "btnLateDelivery";
            this.btnLateDelivery.Size = new System.Drawing.Size(409, 74);
            this.btnLateDelivery.TabIndex = 12;
            this.btnLateDelivery.TabStop = true;
            this.btnLateDelivery.Text = "Late Delivery";
            this.btnLateDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLateDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLateDelivery.UseVisualStyleBackColor = false;
            this.btnLateDelivery.CheckedChanged += new System.EventHandler(this.btnLateDelivery_CheckedChanged);
            // 
            // btnInvGen
            // 
            this.btnInvGen.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInvGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnInvGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvGen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvGen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvGen.Location = new System.Drawing.Point(4, 420);
            this.btnInvGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvGen.Name = "btnInvGen";
            this.btnInvGen.Size = new System.Drawing.Size(409, 74);
            this.btnInvGen.TabIndex = 11;
            this.btnInvGen.TabStop = true;
            this.btnInvGen.Text = "Invoice Generate";
            this.btnInvGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvGen.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewInvoice.Location = new System.Drawing.Point(4, 346);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(409, 74);
            this.btnViewInvoice.TabIndex = 9;
            this.btnViewInvoice.TabStop = true;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.CheckedChanged += new System.EventHandler(this.btnViewInvoice_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(4, 272);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(409, 74);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(4, 882);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(409, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.CheckedChanged += new System.EventHandler(this.btnLogout_CheckedChanged);
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(4, 198);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(409, 74);
            this.lblDept.TabIndex = 1;
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(4, 5);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(409, 193);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bar.Controls.Add(this.lblTitle);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(419, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1505, 90);
            this.bar.TabIndex = 46;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 41);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Invoice Generate";
            // 
            // InvPreview
            // 
            this.InvPreview.BackColor = System.Drawing.Color.White;
            this.InvPreview.Controls.Add(this.dgv);
            this.InvPreview.Controls.Add(this.email);
            this.InvPreview.Controls.Add(this.tel);
            this.InvPreview.Controls.Add(this.lblAddr);
            this.InvPreview.Controls.Add(this.lblDPhone);
            this.InvPreview.Controls.Add(this.lblDName);
            this.InvPreview.Controls.Add(this.BAddr);
            this.InvPreview.Controls.Add(this.lblDCom);
            this.InvPreview.Controls.Add(this.lblOrderDate);
            this.InvPreview.Controls.Add(this.lblOrderID);
            this.InvPreview.Controls.Add(this.Bemail);
            this.InvPreview.Controls.Add(this.Btel);
            this.InvPreview.Controls.Add(this.addr);
            this.InvPreview.Controls.Add(this.BOrderID);
            this.InvPreview.Controls.Add(this.BDAddr);
            this.InvPreview.Controls.Add(this.BDPhone);
            this.InvPreview.Controls.Add(this.BDCom);
            this.InvPreview.Controls.Add(this.BDName);
            this.InvPreview.Controls.Add(this.BOrderDate);
            this.InvPreview.Location = new System.Drawing.Point(426, 163);
            this.InvPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InvPreview.Name = "InvPreview";
            this.InvPreview.Size = new System.Drawing.Size(1482, 605);
            this.InvPreview.TabIndex = 1;
            this.InvPreview.Visible = false;
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.White;
            this.heading.Controls.Add(this.compName);
            this.heading.Location = new System.Drawing.Point(426, 98);
            this.heading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1482, 67);
            this.heading.TabIndex = 40;
            this.heading.Visible = false;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.White;
            this.footer.Controls.Add(this.Bsign);
            this.footer.Controls.Add(this.BItems);
            this.footer.Controls.Add(this.BPrice);
            this.footer.Controls.Add(this.sign);
            this.footer.Controls.Add(this.lblPrice);
            this.footer.Controls.Add(this.lblItems);
            this.footer.Location = new System.Drawing.Point(426, 767);
            this.footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1482, 113);
            this.footer.TabIndex = 41;
            this.footer.Visible = false;
            // 
            // InvoiceGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 949);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.InvPreview);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InvoiceGenerate";
            this.Text = "InvoiceGenerateAndDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.InvPreview.ResumeLayout(false);
            this.InvPreview.PerformLayout();
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label compName;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label BDAddr;
        private System.Windows.Forms.Label BDPhone;
        private System.Windows.Forms.Label BDName;
        private System.Windows.Forms.Label BOrderDate;
        private System.Windows.Forms.Label BDCom;
        private System.Windows.Forms.Label BOrderID;
        private System.Windows.Forms.Label Bemail;
        private System.Windows.Forms.Label Btel;
        private System.Windows.Forms.Label addr;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblDCom;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label BAddr;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblDPhone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label Bsign;
        private System.Windows.Forms.Label BPrice;
        private System.Windows.Forms.Label BItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnViewInvoice;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel InvPreview;
        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.RadioButton btnLateDelivery;
        private System.Windows.Forms.RadioButton btnInvGen;
    }
}