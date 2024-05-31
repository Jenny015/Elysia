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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblDPhone = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.Blabel19 = new System.Windows.Forms.Label();
            this.lblDCom = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.Blabel12 = new System.Windows.Forms.Label();
            this.Blabel11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Blabel9 = new System.Windows.Forms.Label();
            this.Blabel8 = new System.Windows.Forms.Label();
            this.Blabel6 = new System.Windows.Forms.Label();
            this.Blabel2 = new System.Windows.Forms.Label();
            this.Blabel5 = new System.Windows.Forms.Label();
            this.Blabel3 = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Blabel15 = new System.Windows.Forms.Label();
            this.Blabel14 = new System.Windows.Forms.Label();
            this.Blabel13 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewOrder = new System.Windows.Forms.RadioButton();
            this.btnLateDelivery = new System.Windows.Forms.RadioButton();
            this.btnViewInvoice = new System.Windows.Forms.RadioButton();
            this.btnInvGen = new System.Windows.Forms.RadioButton();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrder.Location = new System.Drawing.Point(426, 117);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(1482, 862);
            this.dgvOrder.TabIndex = 32;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1756, 995);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 45);
            this.btnFilter.TabIndex = 33;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label20.Location = new System.Drawing.Point(1125, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 22);
            this.label20.TabIndex = 39;
            this.label20.Text = "salesoffice@lm.com";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label18.Location = new System.Drawing.Point(1125, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 22);
            this.label18.TabIndex = 38;
            this.label18.Text = "22332323";
            // 
            // lblAddr
            // 
            this.lblAddr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblAddr.Location = new System.Drawing.Point(176, 117);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(597, 52);
            this.lblAddr.TabIndex = 37;
            this.lblAddr.Text = "label18";
            // 
            // lblDPhone
            // 
            this.lblDPhone.AutoSize = true;
            this.lblDPhone.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDPhone.Location = new System.Drawing.Point(507, 80);
            this.lblDPhone.Name = "lblDPhone";
            this.lblDPhone.Size = new System.Drawing.Size(70, 22);
            this.lblDPhone.TabIndex = 36;
            this.lblDPhone.Text = "label18";
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDName.Location = new System.Drawing.Point(176, 80);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(70, 22);
            this.lblDName.TabIndex = 35;
            this.lblDName.Text = "label18";
            // 
            // Blabel19
            // 
            this.Blabel19.AutoSize = true;
            this.Blabel19.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel19.Location = new System.Drawing.Point(992, 7);
            this.Blabel19.Name = "Blabel19";
            this.Blabel19.Size = new System.Drawing.Size(90, 23);
            this.Blabel19.TabIndex = 34;
            this.Blabel19.Text = "Address: ";
            // 
            // lblDCom
            // 
            this.lblDCom.AutoSize = true;
            this.lblDCom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDCom.Location = new System.Drawing.Point(176, 43);
            this.lblDCom.Name = "lblDCom";
            this.lblDCom.Size = new System.Drawing.Size(70, 22);
            this.lblDCom.TabIndex = 33;
            this.lblDCom.Text = "label18";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(507, 6);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(70, 22);
            this.lblOrderDate.TabIndex = 31;
            this.lblOrderDate.Text = "label18";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderID.Location = new System.Drawing.Point(176, 6);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 22);
            this.lblOrderID.TabIndex = 30;
            this.lblOrderID.Text = "label18";
            // 
            // Blabel12
            // 
            this.Blabel12.AutoSize = true;
            this.Blabel12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel12.Location = new System.Drawing.Point(992, 144);
            this.Blabel12.Name = "Blabel12";
            this.Blabel12.Size = new System.Drawing.Size(70, 23);
            this.Blabel12.TabIndex = 29;
            this.Blabel12.Text = "Email: ";
            // 
            // Blabel11
            // 
            this.Blabel11.AutoSize = true;
            this.Blabel11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel11.Location = new System.Drawing.Point(992, 107);
            this.Blabel11.Name = "Blabel11";
            this.Blabel11.Size = new System.Drawing.Size(48, 23);
            this.Blabel11.TabIndex = 28;
            this.Blabel11.Text = "Tel: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label10.Location = new System.Drawing.Point(1125, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 88);
            this.label10.TabIndex = 27;
            this.label10.Text = "12/F, Tower 1,\r\nPhase 1 - Enterprise Square One,\r\nEnterprise Square, 9 Sheung Yue" +
    "t Road,\r\nKOWLOON BAY, KOWLOON";
            // 
            // Blabel9
            // 
            this.Blabel9.AutoSize = true;
            this.Blabel9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel9.Location = new System.Drawing.Point(15, 115);
            this.Blabel9.Name = "Blabel9";
            this.Blabel9.Size = new System.Drawing.Size(166, 23);
            this.Blabel9.TabIndex = 26;
            this.Blabel9.Text = "Delivery Address: ";
            // 
            // Blabel8
            // 
            this.Blabel8.AutoSize = true;
            this.Blabel8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel8.Location = new System.Drawing.Point(376, 78);
            this.Blabel8.Name = "Blabel8";
            this.Blabel8.Size = new System.Drawing.Size(136, 23);
            this.Blabel8.TabIndex = 25;
            this.Blabel8.Text = "Dealer Phone: ";
            // 
            // Blabel6
            // 
            this.Blabel6.AutoSize = true;
            this.Blabel6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel6.Location = new System.Drawing.Point(15, 78);
            this.Blabel6.Name = "Blabel6";
            this.Blabel6.Size = new System.Drawing.Size(133, 23);
            this.Blabel6.TabIndex = 23;
            this.Blabel6.Text = "Dealer Name: ";
            // 
            // Blabel2
            // 
            this.Blabel2.AutoSize = true;
            this.Blabel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel2.Location = new System.Drawing.Point(376, 4);
            this.Blabel2.Name = "Blabel2";
            this.Blabel2.Size = new System.Drawing.Size(120, 23);
            this.Blabel2.TabIndex = 22;
            this.Blabel2.Text = "Order Date: ";
            // 
            // Blabel5
            // 
            this.Blabel5.AutoSize = true;
            this.Blabel5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel5.Location = new System.Drawing.Point(15, 41);
            this.Blabel5.Name = "Blabel5";
            this.Blabel5.Size = new System.Drawing.Size(163, 23);
            this.Blabel5.TabIndex = 21;
            this.Blabel5.Text = "Dealer Company: ";
            // 
            // Blabel3
            // 
            this.Blabel3.AutoSize = true;
            this.Blabel3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel3.Location = new System.Drawing.Point(15, 6);
            this.Blabel3.Name = "Blabel3";
            this.Blabel3.Size = new System.Drawing.Size(100, 23);
            this.Blabel3.TabIndex = 20;
            this.Blabel3.Text = "Order ID: ";
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.compName.Location = new System.Drawing.Point(431, 20);
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
            this.dgv.Location = new System.Drawing.Point(16, 187);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(1448, 477);
            this.dgv.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPrice.Location = new System.Drawing.Point(371, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 22);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "label18";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblItems.Location = new System.Drawing.Point(136, 20);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(70, 22);
            this.lblItems.TabIndex = 38;
            this.lblItems.Text = "label18";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(1186, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(252, 26);
            this.label16.TabIndex = 33;
            this.label16.Text = "____________________";
            // 
            // Blabel15
            // 
            this.Blabel15.AutoSize = true;
            this.Blabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Blabel15.Location = new System.Drawing.Point(1066, 55);
            this.Blabel15.Name = "Blabel15";
            this.Blabel15.Size = new System.Drawing.Size(126, 26);
            this.Blabel15.TabIndex = 32;
            this.Blabel15.Text = "Signature: ";
            // 
            // Blabel14
            // 
            this.Blabel14.AutoSize = true;
            this.Blabel14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel14.Location = new System.Drawing.Point(263, 18);
            this.Blabel14.Name = "Blabel14";
            this.Blabel14.Size = new System.Drawing.Size(114, 23);
            this.Blabel14.TabIndex = 31;
            this.Blabel14.Text = "Total Price: ";
            // 
            // Blabel13
            // 
            this.Blabel13.AutoSize = true;
            this.Blabel13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Blabel13.Location = new System.Drawing.Point(10, 18);
            this.Blabel13.Name = "Blabel13";
            this.Blabel13.Size = new System.Drawing.Size(117, 23);
            this.Blabel13.TabIndex = 30;
            this.Blabel13.Text = "Total Items: ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Plum;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1590, 995);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 46);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1758, 995);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 45);
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
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.btnLateDelivery);
            this.panel1.Controls.Add(this.btnViewInvoice);
            this.panel1.Controls.Add(this.btnInvGen);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(419, 1062);
            this.panel1.TabIndex = 45;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrder.Location = new System.Drawing.Point(4, 635);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(409, 83);
            this.btnViewOrder.TabIndex = 11;
            this.btnViewOrder.TabStop = true;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewOrder.UseVisualStyleBackColor = false;
            // 
            // btnLateDelivery
            // 
            this.btnLateDelivery.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLateDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLateDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLateDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLateDelivery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLateDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLateDelivery.Location = new System.Drawing.Point(4, 552);
            this.btnLateDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLateDelivery.Name = "btnLateDelivery";
            this.btnLateDelivery.Size = new System.Drawing.Size(409, 83);
            this.btnLateDelivery.TabIndex = 10;
            this.btnLateDelivery.TabStop = true;
            this.btnLateDelivery.Text = "Late Delivery";
            this.btnLateDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLateDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLateDelivery.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewInvoice.Location = new System.Drawing.Point(4, 469);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(409, 83);
            this.btnViewInvoice.TabIndex = 9;
            this.btnViewInvoice.TabStop = true;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.CheckedChanged += new System.EventHandler(this.btnViewInvoice_CheckedChanged);
            // 
            // btnInvGen
            // 
            this.btnInvGen.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInvGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnInvGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvGen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnInvGen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvGen.Location = new System.Drawing.Point(4, 386);
            this.btnInvGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvGen.Name = "btnInvGen";
            this.btnInvGen.Size = new System.Drawing.Size(409, 83);
            this.btnInvGen.TabIndex = 8;
            this.btnInvGen.TabStop = true;
            this.btnInvGen.Text = "Invoice Generate";
            this.btnInvGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvGen.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(4, 303);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(409, 83);
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
            this.btnLogout.Location = new System.Drawing.Point(4, 989);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(409, 66);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.CheckedChanged += new System.EventHandler(this.btnLogout_CheckedChanged_1);
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(4, 220);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(409, 83);
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
            this.imgLogo.Size = new System.Drawing.Size(409, 215);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bar.Controls.Add(this.lblTitle);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(419, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1505, 100);
            this.bar.TabIndex = 46;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 41);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "View Invoice";
            // 
            // InvPreview
            // 
            this.InvPreview.BackColor = System.Drawing.Color.White;
            this.InvPreview.Controls.Add(this.dgv);
            this.InvPreview.Controls.Add(this.label20);
            this.InvPreview.Controls.Add(this.label18);
            this.InvPreview.Controls.Add(this.lblAddr);
            this.InvPreview.Controls.Add(this.lblDPhone);
            this.InvPreview.Controls.Add(this.lblDName);
            this.InvPreview.Controls.Add(this.Blabel19);
            this.InvPreview.Controls.Add(this.lblDCom);
            this.InvPreview.Controls.Add(this.lblOrderDate);
            this.InvPreview.Controls.Add(this.lblOrderID);
            this.InvPreview.Controls.Add(this.Blabel12);
            this.InvPreview.Controls.Add(this.Blabel11);
            this.InvPreview.Controls.Add(this.label10);
            this.InvPreview.Controls.Add(this.Blabel3);
            this.InvPreview.Controls.Add(this.Blabel9);
            this.InvPreview.Controls.Add(this.Blabel8);
            this.InvPreview.Controls.Add(this.Blabel5);
            this.InvPreview.Controls.Add(this.Blabel6);
            this.InvPreview.Controls.Add(this.Blabel2);
            this.InvPreview.Location = new System.Drawing.Point(426, 181);
            this.InvPreview.Name = "InvPreview";
            this.InvPreview.Size = new System.Drawing.Size(1482, 672);
            this.InvPreview.TabIndex = 1;
            this.InvPreview.Visible = false;
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.White;
            this.heading.Controls.Add(this.compName);
            this.heading.Location = new System.Drawing.Point(426, 109);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1482, 75);
            this.heading.TabIndex = 40;
            this.heading.Visible = false;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.White;
            this.footer.Controls.Add(this.Blabel15);
            this.footer.Controls.Add(this.Blabel13);
            this.footer.Controls.Add(this.Blabel14);
            this.footer.Controls.Add(this.label16);
            this.footer.Controls.Add(this.lblPrice);
            this.footer.Controls.Add(this.lblItems);
            this.footer.Location = new System.Drawing.Point(426, 852);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1482, 125);
            this.footer.TabIndex = 41;
            this.footer.Visible = false;
            // 
            // InvoiceGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.InvPreview);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvOrder);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label Blabel9;
        private System.Windows.Forms.Label Blabel8;
        private System.Windows.Forms.Label Blabel6;
        private System.Windows.Forms.Label Blabel2;
        private System.Windows.Forms.Label Blabel5;
        private System.Windows.Forms.Label Blabel3;
        private System.Windows.Forms.Label Blabel12;
        private System.Windows.Forms.Label Blabel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblDCom;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label Blabel19;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblDPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Blabel15;
        private System.Windows.Forms.Label Blabel14;
        private System.Windows.Forms.Label Blabel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnViewOrder;
        private System.Windows.Forms.RadioButton btnLateDelivery;
        private System.Windows.Forms.RadioButton btnViewInvoice;
        private System.Windows.Forms.RadioButton btnInvGen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel InvPreview;
        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Panel footer;
    }
}