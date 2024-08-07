﻿namespace Elysia
{
    partial class InvoiceGenerate
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.heading = new System.Windows.Forms.Panel();
            this.compName = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.Bsign = new System.Windows.Forms.Label();
            this.BItems = new System.Windows.Forms.Label();
            this.BPrice = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.InvPreview = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
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
            this.BOrderID = new System.Windows.Forms.Label();
            this.BDAddr = new System.Windows.Forms.Label();
            this.BDPhone = new System.Windows.Forms.Label();
            this.BDCom = new System.Windows.Forms.Label();
            this.BDName = new System.Windows.Forms.Label();
            this.BOrderDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.heading.SuspendLayout();
            this.footer.SuspendLayout();
            this.InvPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.White;
            this.heading.Controls.Add(this.compName);
            this.heading.Location = new System.Drawing.Point(7, 83);
            this.heading.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(988, 55);
            this.heading.TabIndex = 47;
            this.heading.Visible = false;
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.compName.Location = new System.Drawing.Point(287, 13);
            this.compName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(377, 23);
            this.compName.TabIndex = 1;
            this.compName.Text = "Legend Motor (LC) Limited Company";
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
            this.footer.Location = new System.Drawing.Point(7, 616);
            this.footer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(988, 82);
            this.footer.TabIndex = 48;
            this.footer.Visible = false;
            // 
            // Bsign
            // 
            this.Bsign.AutoSize = true;
            this.Bsign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Bsign.Location = new System.Drawing.Point(711, 35);
            this.Bsign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bsign.Name = "Bsign";
            this.Bsign.Size = new System.Drawing.Size(82, 19);
            this.Bsign.TabIndex = 32;
            this.Bsign.Text = "Signature: ";
            // 
            // BItems
            // 
            this.BItems.AutoSize = true;
            this.BItems.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BItems.Location = new System.Drawing.Point(7, 12);
            this.BItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BItems.Name = "BItems";
            this.BItems.Size = new System.Drawing.Size(87, 17);
            this.BItems.TabIndex = 30;
            this.BItems.Text = "Total Items: ";
            // 
            // BPrice
            // 
            this.BPrice.AutoSize = true;
            this.BPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BPrice.Location = new System.Drawing.Point(175, 12);
            this.BPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BPrice.Name = "BPrice";
            this.BPrice.Size = new System.Drawing.Size(82, 17);
            this.BPrice.TabIndex = 31;
            this.BPrice.Text = "Total Price: ";
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.sign.Location = new System.Drawing.Point(791, 47);
            this.sign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(169, 19);
            this.sign.TabIndex = 33;
            this.sign.Text = "____________________";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPrice.Location = new System.Drawing.Point(247, 13);
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
            this.lblItems.Location = new System.Drawing.Point(91, 13);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(46, 16);
            this.lblItems.TabIndex = 38;
            this.lblItems.Text = "label18";
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
            this.InvPreview.Location = new System.Drawing.Point(7, 141);
            this.InvPreview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.InvPreview.Name = "InvPreview";
            this.InvPreview.Size = new System.Drawing.Size(988, 478);
            this.InvPreview.TabIndex = 42;
            this.InvPreview.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 121);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(965, 337);
            this.dgv.TabIndex = 0;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.email.Location = new System.Drawing.Point(750, 95);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(123, 16);
            this.email.TabIndex = 39;
            this.email.Text = "salesoffice@lm.com";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tel.Location = new System.Drawing.Point(750, 72);
            this.tel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(63, 16);
            this.tel.TabIndex = 38;
            this.tel.Text = "22332323";
            // 
            // lblAddr
            // 
            this.lblAddr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblAddr.Location = new System.Drawing.Point(117, 77);
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
            this.lblDPhone.Location = new System.Drawing.Point(338, 52);
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
            this.lblDName.Location = new System.Drawing.Point(117, 52);
            this.lblDName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(46, 16);
            this.lblDName.TabIndex = 35;
            this.lblDName.Text = "label18";
            // 
            // BAddr
            // 
            this.BAddr.AutoSize = true;
            this.BAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BAddr.Location = new System.Drawing.Point(661, 4);
            this.BAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BAddr.Name = "BAddr";
            this.BAddr.Size = new System.Drawing.Size(66, 17);
            this.BAddr.TabIndex = 34;
            this.BAddr.Text = "Address: ";
            // 
            // lblDCom
            // 
            this.lblDCom.AutoSize = true;
            this.lblDCom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDCom.Location = new System.Drawing.Point(117, 27);
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
            this.lblOrderDate.Location = new System.Drawing.Point(338, 4);
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
            this.lblOrderID.Location = new System.Drawing.Point(117, 4);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(46, 16);
            this.lblOrderID.TabIndex = 30;
            this.lblOrderID.Text = "label18";
            // 
            // Bemail
            // 
            this.Bemail.AutoSize = true;
            this.Bemail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Bemail.Location = new System.Drawing.Point(661, 94);
            this.Bemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bemail.Name = "Bemail";
            this.Bemail.Size = new System.Drawing.Size(52, 17);
            this.Bemail.TabIndex = 29;
            this.Bemail.Text = "Email: ";
            // 
            // Btel
            // 
            this.Btel.AutoSize = true;
            this.Btel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Btel.Location = new System.Drawing.Point(661, 69);
            this.Btel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Btel.Name = "Btel";
            this.Btel.Size = new System.Drawing.Size(35, 17);
            this.Btel.TabIndex = 28;
            this.Btel.Text = "Tel: ";
            // 
            // addr
            // 
            this.addr.AutoSize = true;
            this.addr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.addr.Location = new System.Drawing.Point(750, 4);
            this.addr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(232, 64);
            this.addr.TabIndex = 27;
            this.addr.Text = "12/F, Tower 1,\r\nPhase 1 - Enterprise Square One,\r\nEnterprise Square, 9 Sheung Yue" +
    "t Road,\r\nKOWLOON BAY, KOWLOON";
            // 
            // BOrderID
            // 
            this.BOrderID.AutoSize = true;
            this.BOrderID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderID.Location = new System.Drawing.Point(10, 4);
            this.BOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BOrderID.Name = "BOrderID";
            this.BOrderID.Size = new System.Drawing.Size(74, 17);
            this.BOrderID.TabIndex = 20;
            this.BOrderID.Text = "Order ID: ";
            // 
            // BDAddr
            // 
            this.BDAddr.AutoSize = true;
            this.BDAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDAddr.Location = new System.Drawing.Point(10, 74);
            this.BDAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BDAddr.Name = "BDAddr";
            this.BDAddr.Size = new System.Drawing.Size(121, 17);
            this.BDAddr.TabIndex = 26;
            this.BDAddr.Text = "Delivery Address: ";
            // 
            // BDPhone
            // 
            this.BDPhone.AutoSize = true;
            this.BDPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDPhone.Location = new System.Drawing.Point(251, 51);
            this.BDPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BDPhone.Name = "BDPhone";
            this.BDPhone.Size = new System.Drawing.Size(100, 17);
            this.BDPhone.TabIndex = 25;
            this.BDPhone.Text = "Dealer Phone: ";
            // 
            // BDCom
            // 
            this.BDCom.AutoSize = true;
            this.BDCom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDCom.Location = new System.Drawing.Point(10, 27);
            this.BDCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BDCom.Name = "BDCom";
            this.BDCom.Size = new System.Drawing.Size(120, 17);
            this.BDCom.TabIndex = 21;
            this.BDCom.Text = "Dealer Company: ";
            // 
            // BDName
            // 
            this.BDName.AutoSize = true;
            this.BDName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDName.Location = new System.Drawing.Point(10, 51);
            this.BDName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BDName.Name = "BDName";
            this.BDName.Size = new System.Drawing.Size(97, 17);
            this.BDName.TabIndex = 23;
            this.BDName.Text = "Dealer Name: ";
            // 
            // BOrderDate
            // 
            this.BOrderDate.AutoSize = true;
            this.BOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderDate.Location = new System.Drawing.Point(251, 3);
            this.BOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BOrderDate.Name = "BOrderDate";
            this.BOrderDate.Size = new System.Drawing.Size(87, 17);
            this.BOrderDate.TabIndex = 22;
            this.BOrderDate.Text = "Order Date: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(895, 716);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Plum;
            this.btnPDF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPDF.Location = new System.Drawing.Point(783, 716);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(100, 30);
            this.btnPDF.TabIndex = 45;
            this.btnPDF.Text = "Save as PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Visible = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(893, 716);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.Location = new System.Drawing.Point(7, 87);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(988, 607);
            this.dgvOrder.TabIndex = 43;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 65);
            this.panel2.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "InvoiceGenerate";
            // 
            // InvoiceGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.InvPreview);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InvoiceGenerate";
            this.Size = new System.Drawing.Size(1002, 762);
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.InvPreview.ResumeLayout(false);
            this.InvPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Label compName;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label Bsign;
        private System.Windows.Forms.Label BItems;
        private System.Windows.Forms.Label BPrice;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Panel InvPreview;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblDPhone;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label BAddr;
        private System.Windows.Forms.Label lblDCom;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label Bemail;
        private System.Windows.Forms.Label Btel;
        private System.Windows.Forms.Label addr;
        private System.Windows.Forms.Label BOrderID;
        private System.Windows.Forms.Label BDAddr;
        private System.Windows.Forms.Label BDPhone;
        private System.Windows.Forms.Label BDCom;
        private System.Windows.Forms.Label BDName;
        private System.Windows.Forms.Label BOrderDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
