namespace Elysia
{
    partial class InvoiceGenerateAndDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceGenerateAndDelivery));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblDPhone = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDCom = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.printPrev = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.bar.SuspendLayout();
            this.InvPreview.SuspendLayout();
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
            this.dgvOrder.Location = new System.Drawing.Point(284, 76);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(988, 560);
            this.dgvOrder.TabIndex = 32;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1171, 647);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 29);
            this.btnFilter.TabIndex = 33;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // printDoc
            // 
            this.printDoc.DocumentName = "Invoice";
            this.printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDoc_BeginPrint);
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label20.Location = new System.Drawing.Point(750, 141);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "salesoffice@lm.com";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label18.Location = new System.Drawing.Point(750, 118);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "22332323";
            // 
            // lblAddr
            // 
            this.lblAddr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblAddr.Location = new System.Drawing.Point(117, 122);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(398, 34);
            this.lblAddr.TabIndex = 37;
            this.lblAddr.Text = "label18";
            // 
            // lblDPhone
            // 
            this.lblDPhone.AutoSize = true;
            this.lblDPhone.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDPhone.Location = new System.Drawing.Point(338, 98);
            this.lblDPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDPhone.Name = "lblDPhone";
            this.lblDPhone.Size = new System.Drawing.Size(46, 16);
            this.lblDPhone.TabIndex = 36;
            this.lblDPhone.Text = "label18";
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDName.Location = new System.Drawing.Point(117, 98);
            this.lblDName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(46, 16);
            this.lblDName.TabIndex = 35;
            this.lblDName.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(661, 51);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 17);
            this.label19.TabIndex = 34;
            this.label19.Text = "Address: ";
            // 
            // lblDCom
            // 
            this.lblDCom.AutoSize = true;
            this.lblDCom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDCom.Location = new System.Drawing.Point(117, 74);
            this.lblDCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDCom.Name = "lblDCom";
            this.lblDCom.Size = new System.Drawing.Size(46, 16);
            this.lblDCom.TabIndex = 33;
            this.lblDCom.Text = "label18";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(338, 50);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(46, 16);
            this.lblOrderDate.TabIndex = 31;
            this.lblOrderDate.Text = "label18";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderID.Location = new System.Drawing.Point(117, 50);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(46, 16);
            this.lblOrderID.TabIndex = 30;
            this.lblOrderID.Text = "label18";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(661, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Email: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(661, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tel: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label10.Location = new System.Drawing.Point(750, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 64);
            this.label10.TabIndex = 27;
            this.label10.Text = "12/F, Tower 1,\r\nPhase 1 - Enterprise Square One,\r\nEnterprise Square, 9 Sheung Yue" +
    "t Road,\r\nKOWLOON BAY, KOWLOON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Delivery Address: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(251, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dealer Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dealer Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(251, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Order Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dealer Company: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Order ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(277, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legend Motor (LC) Limited Company";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 168);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(965, 310);
            this.dgv.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPrice.Location = new System.Drawing.Point(251, 494);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "label18";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblItems.Location = new System.Drawing.Point(94, 494);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(46, 16);
            this.lblItems.TabIndex = 38;
            this.lblItems.Text = "label18";
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Location = new System.Drawing.Point(480, 521);
            this.lblTotalPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPage.TabIndex = 36;
            this.lblTotalPage.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(467, 521);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "/";
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.Location = new System.Drawing.Point(455, 521);
            this.lblCurrPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(13, 13);
            this.lblCurrPage.TabIndex = 34;
            this.lblCurrPage.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(802, 507);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "____________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(714, 496);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Signature: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(179, 493);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Total Price: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(10, 493);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Items: ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Plum;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1060, 647);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1172, 647);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 29);
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
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(280, 690);
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
            this.btnViewOrder.Location = new System.Drawing.Point(3, 413);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(272, 54);
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
            this.btnLateDelivery.Location = new System.Drawing.Point(3, 359);
            this.btnLateDelivery.Name = "btnLateDelivery";
            this.btnLateDelivery.Size = new System.Drawing.Size(272, 54);
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
            this.btnViewInvoice.Location = new System.Drawing.Point(3, 305);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(272, 54);
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
            this.btnInvGen.Location = new System.Drawing.Point(3, 251);
            this.btnInvGen.Name = "btnInvGen";
            this.btnInvGen.Size = new System.Drawing.Size(272, 54);
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
            this.radioButton1.Location = new System.Drawing.Point(3, 197);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(272, 54);
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
            this.btnLogout.Location = new System.Drawing.Point(3, 642);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(272, 43);
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
            this.lblDept.Location = new System.Drawing.Point(3, 143);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(272, 54);
            this.lblDept.TabIndex = 1;
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
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bar.Controls.Add(this.lblTitle);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(280, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1003, 65);
            this.bar.TabIndex = 46;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 29);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "View Invoice";
            // 
            // InvPreview
            // 
            this.InvPreview.BackColor = System.Drawing.Color.White;
            this.InvPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvPreview.Controls.Add(this.dgv);
            this.InvPreview.Controls.Add(this.label20);
            this.InvPreview.Controls.Add(this.lblPrice);
            this.InvPreview.Controls.Add(this.label18);
            this.InvPreview.Controls.Add(this.lblAddr);
            this.InvPreview.Controls.Add(this.lblItems);
            this.InvPreview.Controls.Add(this.lblDPhone);
            this.InvPreview.Controls.Add(this.label15);
            this.InvPreview.Controls.Add(this.lblDName);
            this.InvPreview.Controls.Add(this.label19);
            this.InvPreview.Controls.Add(this.lblTotalPage);
            this.InvPreview.Controls.Add(this.lblDCom);
            this.InvPreview.Controls.Add(this.label16);
            this.InvPreview.Controls.Add(this.lblOrderDate);
            this.InvPreview.Controls.Add(this.label14);
            this.InvPreview.Controls.Add(this.lblOrderID);
            this.InvPreview.Controls.Add(this.lblCurrPage);
            this.InvPreview.Controls.Add(this.label12);
            this.InvPreview.Controls.Add(this.label13);
            this.InvPreview.Controls.Add(this.label11);
            this.InvPreview.Controls.Add(this.label17);
            this.InvPreview.Controls.Add(this.label10);
            this.InvPreview.Controls.Add(this.label3);
            this.InvPreview.Controls.Add(this.label9);
            this.InvPreview.Controls.Add(this.label1);
            this.InvPreview.Controls.Add(this.label8);
            this.InvPreview.Controls.Add(this.label5);
            this.InvPreview.Controls.Add(this.label6);
            this.InvPreview.Controls.Add(this.label2);
            this.InvPreview.Location = new System.Drawing.Point(284, 76);
            this.InvPreview.Margin = new System.Windows.Forms.Padding(2);
            this.InvPreview.Name = "InvPreview";
            this.InvPreview.Size = new System.Drawing.Size(989, 560);
            this.InvPreview.TabIndex = 1;
            this.InvPreview.Visible = false;
            // 
            // printPrev
            // 
            this.printPrev.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPrev.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPrev.ClientSize = new System.Drawing.Size(400, 300);
            this.printPrev.Enabled = true;
            this.printPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("printPrev.Icon")));
            this.printPrev.Name = "printPrev";
            this.printPrev.Visible = false;
            // 
            // InvoiceGenerateAndDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.InvPreview);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceGenerateAndDelivery";
            this.Text = "InvoiceGenerateAndDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.InvPreview.ResumeLayout(false);
            this.InvPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnFilter;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblDCom;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblDPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCurrPage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.PrintPreviewDialog printPrev;
    }
}