namespace Elysia
{
    partial class Filter
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
            this.DID = new System.Windows.Forms.Panel();
            this.didPartID = new System.Windows.Forms.ComboBox();
            this.didOrderID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.didAll = new System.Windows.Forms.RadioButton();
            this.didA = new System.Windows.Forms.RadioButton();
            this.didP = new System.Windows.Forms.RadioButton();
            this.didO = new System.Windows.Forms.RadioButton();
            this.didC = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.invoice = new System.Windows.Forms.Panel();
            this.invOrderID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.invAll = new System.Windows.Forms.RadioButton();
            this.invSend = new System.Windows.Forms.RadioButton();
            this.invW = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.orderDateContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oDateFrom = new System.Windows.Forms.DateTimePicker();
            this.oDateTo = new System.Windows.Forms.DateTimePicker();
            this.Order = new System.Windows.Forms.Panel();
            this.rbOStatusAll = new System.Windows.Forms.RadioButton();
            this.rbOStatusD = new System.Windows.Forms.RadioButton();
            this.rbOStatusA = new System.Windows.Forms.RadioButton();
            this.rbOStatusC = new System.Windows.Forms.RadioButton();
            this.rbOStatusO = new System.Windows.Forms.RadioButton();
            this.rbOStatusP = new System.Windows.Forms.RadioButton();
            this.invSign = new System.Windows.Forms.RadioButton();
            this.DID.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.invoice.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.orderDateContainer.SuspendLayout();
            this.Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // DID
            // 
            this.DID.Controls.Add(this.didPartID);
            this.DID.Controls.Add(this.didOrderID);
            this.DID.Controls.Add(this.label2);
            this.DID.Controls.Add(this.label6);
            this.DID.Controls.Add(this.groupBox2);
            this.DID.Location = new System.Drawing.Point(494, 283);
            this.DID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(460, 292);
            this.DID.TabIndex = 6;
            this.DID.Visible = false;
            // 
            // didPartID
            // 
            this.didPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didPartID.FormattingEnabled = true;
            this.didPartID.Location = new System.Drawing.Point(149, 82);
            this.didPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didPartID.Name = "didPartID";
            this.didPartID.Size = new System.Drawing.Size(179, 27);
            this.didPartID.TabIndex = 19;
            // 
            // didOrderID
            // 
            this.didOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didOrderID.FormattingEnabled = true;
            this.didOrderID.Location = new System.Drawing.Point(149, 27);
            this.didOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didOrderID.Name = "didOrderID";
            this.didOrderID.Size = new System.Drawing.Size(179, 27);
            this.didOrderID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Part ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.didAll);
            this.groupBox2.Controls.Add(this.didA);
            this.groupBox2.Controls.Add(this.didP);
            this.groupBox2.Controls.Add(this.didO);
            this.groupBox2.Controls.Add(this.didC);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(25, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(408, 122);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DID Status";
            // 
            // didAll
            // 
            this.didAll.AutoSize = true;
            this.didAll.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.didAll.Location = new System.Drawing.Point(276, 61);
            this.didAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didAll.Name = "didAll";
            this.didAll.Size = new System.Drawing.Size(102, 23);
            this.didAll.TabIndex = 19;
            this.didAll.Text = "All Status";
            this.didAll.UseVisualStyleBackColor = true;
            // 
            // didA
            // 
            this.didA.AutoSize = true;
            this.didA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didA.Location = new System.Drawing.Point(147, 36);
            this.didA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didA.Name = "didA";
            this.didA.Size = new System.Drawing.Size(105, 23);
            this.didA.TabIndex = 18;
            this.didA.Text = "Assembled";
            this.didA.UseVisualStyleBackColor = true;
            // 
            // didP
            // 
            this.didP.AutoSize = true;
            this.didP.Checked = true;
            this.didP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didP.Location = new System.Drawing.Point(20, 36);
            this.didP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didP.Name = "didP";
            this.didP.Size = new System.Drawing.Size(106, 23);
            this.didP.TabIndex = 17;
            this.didP.TabStop = true;
            this.didP.Text = "Processing";
            this.didP.UseVisualStyleBackColor = true;
            // 
            // didO
            // 
            this.didO.AutoSize = true;
            this.didO.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didO.Location = new System.Drawing.Point(20, 78);
            this.didO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didO.Name = "didO";
            this.didO.Size = new System.Drawing.Size(100, 23);
            this.didO.TabIndex = 16;
            this.didO.Text = "OStanding";
            this.didO.UseVisualStyleBackColor = true;
            // 
            // didC
            // 
            this.didC.AutoSize = true;
            this.didC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didC.Location = new System.Drawing.Point(147, 78);
            this.didC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didC.Name = "didC";
            this.didC.Size = new System.Drawing.Size(98, 23);
            this.didC.TabIndex = 15;
            this.didC.Text = "Cancelled";
            this.didC.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(176, 476);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // invoice
            // 
            this.invoice.Controls.Add(this.invOrderID);
            this.invoice.Controls.Add(this.label8);
            this.invoice.Controls.Add(this.groupBox3);
            this.invoice.Location = new System.Drawing.Point(494, 11);
            this.invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(356, 242);
            this.invoice.TabIndex = 20;
            this.invoice.Visible = false;
            // 
            // invOrderID
            // 
            this.invOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invOrderID.FormattingEnabled = true;
            this.invOrderID.Location = new System.Drawing.Point(149, 27);
            this.invOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invOrderID.Name = "invOrderID";
            this.invOrderID.Size = new System.Drawing.Size(179, 27);
            this.invOrderID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Order ID: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.invSign);
            this.groupBox3.Controls.Add(this.invAll);
            this.groupBox3.Controls.Add(this.invSend);
            this.groupBox3.Controls.Add(this.invW);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(25, 82);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(303, 128);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice Status";
            // 
            // invAll
            // 
            this.invAll.AutoSize = true;
            this.invAll.Checked = true;
            this.invAll.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invAll.Location = new System.Drawing.Point(158, 83);
            this.invAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invAll.Name = "invAll";
            this.invAll.Size = new System.Drawing.Size(102, 23);
            this.invAll.TabIndex = 19;
            this.invAll.TabStop = true;
            this.invAll.Text = "All Status";
            this.invAll.UseVisualStyleBackColor = true;
            // 
            // invSend
            // 
            this.invSend.AutoSize = true;
            this.invSend.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invSend.Location = new System.Drawing.Point(158, 40);
            this.invSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invSend.Name = "invSend";
            this.invSend.Size = new System.Drawing.Size(63, 23);
            this.invSend.TabIndex = 18;
            this.invSend.Text = "Send";
            this.invSend.UseVisualStyleBackColor = true;
            // 
            // invW
            // 
            this.invW.AutoSize = true;
            this.invW.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invW.Location = new System.Drawing.Point(38, 40);
            this.invW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invW.Name = "invW";
            this.invW.Size = new System.Drawing.Size(62, 23);
            this.invW.TabIndex = 16;
            this.invW.Text = "Wait";
            this.invW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOStatusAll);
            this.groupBox1.Controls.Add(this.rbOStatusA);
            this.groupBox1.Controls.Add(this.rbOStatusP);
            this.groupBox1.Controls.Add(this.rbOStatusO);
            this.groupBox1.Controls.Add(this.rbOStatusC);
            this.groupBox1.Controls.Add(this.rbOStatusD);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dealer ID: ";
            // 
            // cbOrderID
            // 
            this.cbOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(144, 38);
            this.cbOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(179, 27);
            this.cbOrderID.TabIndex = 13;
            // 
            // cbDealerID
            // 
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(144, 93);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(179, 27);
            this.cbDealerID.TabIndex = 14;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDate.Location = new System.Drawing.Point(29, 298);
            this.cbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(153, 23);
            this.cbDate.TabIndex = 15;
            this.cbDate.Text = "Querying by date?";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // orderDateContainer
            // 
            this.orderDateContainer.Controls.Add(this.oDateTo);
            this.orderDateContainer.Controls.Add(this.oDateFrom);
            this.orderDateContainer.Controls.Add(this.label4);
            this.orderDateContainer.Controls.Add(this.label1);
            this.orderDateContainer.Enabled = false;
            this.orderDateContainer.Location = new System.Drawing.Point(20, 325);
            this.orderDateContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDateContainer.Name = "orderDateContainer";
            this.orderDateContainer.Size = new System.Drawing.Size(408, 102);
            this.orderDateContainer.TabIndex = 16;
            this.orderDateContainer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "To";
            // 
            // oDateFrom
            // 
            this.oDateFrom.CustomFormat = "yyyy-MM-dd";
            this.oDateFrom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateFrom.Location = new System.Drawing.Point(76, 18);
            this.oDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oDateFrom.Name = "oDateFrom";
            this.oDateFrom.Size = new System.Drawing.Size(276, 27);
            this.oDateFrom.TabIndex = 2;
            this.oDateFrom.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // oDateTo
            // 
            this.oDateTo.CustomFormat = "yyyy-MM-dd";
            this.oDateTo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateTo.Location = new System.Drawing.Point(76, 58);
            this.oDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oDateTo.Name = "oDateTo";
            this.oDateTo.Size = new System.Drawing.Size(276, 27);
            this.oDateTo.TabIndex = 3;
            this.oDateTo.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // Order
            // 
            this.Order.Controls.Add(this.orderDateContainer);
            this.Order.Controls.Add(this.cbDate);
            this.Order.Controls.Add(this.cbDealerID);
            this.Order.Controls.Add(this.cbOrderID);
            this.Order.Controls.Add(this.label5);
            this.Order.Controls.Add(this.label3);
            this.Order.Controls.Add(this.groupBox1);
            this.Order.Location = new System.Drawing.Point(9, 9);
            this.Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(460, 442);
            this.Order.TabIndex = 7;
            this.Order.Visible = false;
            // 
            // rbOStatusAll
            // 
            this.rbOStatusAll.AutoSize = true;
            this.rbOStatusAll.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOStatusAll.Location = new System.Drawing.Point(276, 78);
            this.rbOStatusAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusAll.Name = "rbOStatusAll";
            this.rbOStatusAll.Size = new System.Drawing.Size(102, 23);
            this.rbOStatusAll.TabIndex = 19;
            this.rbOStatusAll.Text = "All Status";
            this.rbOStatusAll.UseVisualStyleBackColor = true;
            // 
            // rbOStatusD
            // 
            this.rbOStatusD.AutoSize = true;
            this.rbOStatusD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusD.Location = new System.Drawing.Point(276, 36);
            this.rbOStatusD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusD.Name = "rbOStatusD";
            this.rbOStatusD.Size = new System.Drawing.Size(109, 23);
            this.rbOStatusD.TabIndex = 14;
            this.rbOStatusD.Text = "Despatched";
            this.rbOStatusD.UseVisualStyleBackColor = true;
            // 
            // rbOStatusA
            // 
            this.rbOStatusA.AutoSize = true;
            this.rbOStatusA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusA.Location = new System.Drawing.Point(147, 36);
            this.rbOStatusA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusA.Name = "rbOStatusA";
            this.rbOStatusA.Size = new System.Drawing.Size(105, 23);
            this.rbOStatusA.TabIndex = 18;
            this.rbOStatusA.Text = "Assembled";
            this.rbOStatusA.UseVisualStyleBackColor = true;
            // 
            // rbOStatusC
            // 
            this.rbOStatusC.AutoSize = true;
            this.rbOStatusC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusC.Location = new System.Drawing.Point(147, 78);
            this.rbOStatusC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusC.Name = "rbOStatusC";
            this.rbOStatusC.Size = new System.Drawing.Size(98, 23);
            this.rbOStatusC.TabIndex = 15;
            this.rbOStatusC.Text = "Cancelled";
            this.rbOStatusC.UseVisualStyleBackColor = true;
            // 
            // rbOStatusO
            // 
            this.rbOStatusO.AutoSize = true;
            this.rbOStatusO.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusO.Location = new System.Drawing.Point(20, 78);
            this.rbOStatusO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusO.Name = "rbOStatusO";
            this.rbOStatusO.Size = new System.Drawing.Size(100, 23);
            this.rbOStatusO.TabIndex = 16;
            this.rbOStatusO.Text = "OStanding";
            this.rbOStatusO.UseVisualStyleBackColor = true;
            // 
            // rbOStatusP
            // 
            this.rbOStatusP.AutoSize = true;
            this.rbOStatusP.Checked = true;
            this.rbOStatusP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusP.Location = new System.Drawing.Point(20, 36);
            this.rbOStatusP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusP.Name = "rbOStatusP";
            this.rbOStatusP.Size = new System.Drawing.Size(106, 23);
            this.rbOStatusP.TabIndex = 17;
            this.rbOStatusP.TabStop = true;
            this.rbOStatusP.Text = "Processing";
            this.rbOStatusP.UseVisualStyleBackColor = true;
            // 
            // invSign
            // 
            this.invSign.AutoSize = true;
            this.invSign.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invSign.Location = new System.Drawing.Point(38, 83);
            this.invSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invSign.Name = "invSign";
            this.invSign.Size = new System.Drawing.Size(60, 23);
            this.invSign.TabIndex = 20;
            this.invSign.Text = "Sign";
            this.invSign.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1130, 675);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filter";
            this.Text = "Filter";
            this.DID.ResumeLayout(false);
            this.DID.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.invoice.ResumeLayout(false);
            this.invoice.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.orderDateContainer.ResumeLayout(false);
            this.orderDateContainer.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox didPartID;
        private System.Windows.Forms.ComboBox didOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton didAll;
        private System.Windows.Forms.RadioButton didA;
        private System.Windows.Forms.RadioButton didP;
        private System.Windows.Forms.RadioButton didO;
        private System.Windows.Forms.RadioButton didC;
        private System.Windows.Forms.Panel invoice;
        private System.Windows.Forms.ComboBox invOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton invAll;
        private System.Windows.Forms.RadioButton invSend;
        private System.Windows.Forms.RadioButton invW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.ComboBox cbDealerID;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Panel orderDateContainer;
        private System.Windows.Forms.DateTimePicker oDateTo;
        private System.Windows.Forms.DateTimePicker oDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Order;
        private System.Windows.Forms.RadioButton rbOStatusAll;
        private System.Windows.Forms.RadioButton rbOStatusA;
        private System.Windows.Forms.RadioButton rbOStatusO;
        private System.Windows.Forms.RadioButton rbOStatusC;
        private System.Windows.Forms.RadioButton rbOStatusD;
        private System.Windows.Forms.RadioButton rbOStatusP;
        private System.Windows.Forms.RadioButton invSign;
    }
}