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
            this.btnSearch = new System.Windows.Forms.Button();
            this.invoice = new System.Windows.Forms.Panel();
            this.invOrderID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.orderDateContainer = new System.Windows.Forms.Panel();
            this.oDateTo = new System.Windows.Forms.DateTimePicker();
            this.oDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Panel();
            this.inward = new System.Windows.Forms.Panel();
            this.iwPartID = new System.Windows.Forms.ComboBox();
            this.iwDatePanel = new System.Windows.Forms.Panel();
            this.iwTo = new System.Windows.Forms.DateTimePicker();
            this.iwFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iwDate = new System.Windows.Forms.CheckBox();
            this.iwSupplierID = new System.Windows.Forms.ComboBox();
            this.iwID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.invStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.didStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.part = new System.Windows.Forms.Panel();
            this.partStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.partPartID = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.partCategory = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.partPartName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.DID.SuspendLayout();
            this.invoice.SuspendLayout();
            this.orderDateContainer.SuspendLayout();
            this.Order.SuspendLayout();
            this.inward.SuspendLayout();
            this.iwDatePanel.SuspendLayout();
            this.part.SuspendLayout();
            this.SuspendLayout();
            // 
            // DID
            // 
            this.DID.Controls.Add(this.didStatus);
            this.DID.Controls.Add(this.label15);
            this.DID.Controls.Add(this.didPartID);
            this.DID.Controls.Add(this.didOrderID);
            this.DID.Controls.Add(this.label2);
            this.DID.Controls.Add(this.label6);
            this.DID.Location = new System.Drawing.Point(425, 327);
            this.DID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(400, 227);
            this.DID.TabIndex = 6;
            this.DID.Visible = false;
            // 
            // didPartID
            // 
            this.didPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didPartID.FormattingEnabled = true;
            this.didPartID.Location = new System.Drawing.Point(161, 92);
            this.didPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didPartID.Name = "didPartID";
            this.didPartID.Size = new System.Drawing.Size(201, 30);
            this.didPartID.TabIndex = 19;
            // 
            // didOrderID
            // 
            this.didOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didOrderID.FormattingEnabled = true;
            this.didOrderID.Location = new System.Drawing.Point(161, 30);
            this.didOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didOrderID.Name = "didOrderID";
            this.didOrderID.Size = new System.Drawing.Size(201, 30);
            this.didOrderID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Part ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order ID: ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(125, 317);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // invoice
            // 
            this.invoice.Controls.Add(this.label14);
            this.invoice.Controls.Add(this.invStatus);
            this.invoice.Controls.Add(this.invOrderID);
            this.invoice.Controls.Add(this.label8);
            this.invoice.Location = new System.Drawing.Point(14, 492);
            this.invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(400, 176);
            this.invoice.TabIndex = 20;
            this.invoice.Visible = false;
            // 
            // invOrderID
            // 
            this.invOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invOrderID.FormattingEnabled = true;
            this.invOrderID.Location = new System.Drawing.Point(161, 32);
            this.invOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invOrderID.Name = "invOrderID";
            this.invOrderID.Size = new System.Drawing.Size(201, 30);
            this.invOrderID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(29, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Order ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dealer ID: ";
            // 
            // cbOrderID
            // 
            this.cbOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(162, 29);
            this.cbOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(201, 30);
            this.cbOrderID.TabIndex = 13;
            // 
            // cbDealerID
            // 
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(162, 97);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(201, 30);
            this.cbDealerID.TabIndex = 14;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDate.Location = new System.Drawing.Point(35, 230);
            this.cbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(179, 26);
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
            this.orderDateContainer.Location = new System.Drawing.Point(24, 262);
            this.orderDateContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDateContainer.Name = "orderDateContainer";
            this.orderDateContainer.Size = new System.Drawing.Size(459, 122);
            this.orderDateContainer.TabIndex = 16;
            this.orderDateContainer.Visible = false;
            // 
            // oDateTo
            // 
            this.oDateTo.CustomFormat = "yyyy-MM-dd";
            this.oDateTo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateTo.Location = new System.Drawing.Point(86, 70);
            this.oDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oDateTo.Name = "oDateTo";
            this.oDateTo.Size = new System.Drawing.Size(310, 30);
            this.oDateTo.TabIndex = 3;
            this.oDateTo.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // oDateFrom
            // 
            this.oDateFrom.CustomFormat = "yyyy-MM-dd";
            this.oDateFrom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateFrom.Location = new System.Drawing.Point(86, 22);
            this.oDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oDateFrom.Name = "oDateFrom";
            this.oDateFrom.Size = new System.Drawing.Size(310, 30);
            this.oDateFrom.TabIndex = 2;
            this.oDateFrom.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // Order
            // 
            this.Order.Controls.Add(this.label13);
            this.Order.Controls.Add(this.orderStatus);
            this.Order.Controls.Add(this.orderDateContainer);
            this.Order.Controls.Add(this.cbDate);
            this.Order.Controls.Add(this.cbDealerID);
            this.Order.Controls.Add(this.cbOrderID);
            this.Order.Controls.Add(this.label5);
            this.Order.Controls.Add(this.label3);
            this.Order.Location = new System.Drawing.Point(831, 13);
            this.Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(518, 414);
            this.Order.TabIndex = 7;
            this.Order.Visible = false;
            // 
            // inward
            // 
            this.inward.Controls.Add(this.iwPartID);
            this.inward.Controls.Add(this.iwDatePanel);
            this.inward.Controls.Add(this.label12);
            this.inward.Controls.Add(this.iwDate);
            this.inward.Controls.Add(this.iwSupplierID);
            this.inward.Controls.Add(this.iwID);
            this.inward.Controls.Add(this.label10);
            this.inward.Controls.Add(this.label11);
            this.inward.Location = new System.Drawing.Point(14, 701);
            this.inward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inward.Name = "inward";
            this.inward.Size = new System.Drawing.Size(393, 414);
            this.inward.TabIndex = 17;
            this.inward.Visible = false;
            // 
            // iwPartID
            // 
            this.iwPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwPartID.FormattingEnabled = true;
            this.iwPartID.Location = new System.Drawing.Point(162, 167);
            this.iwPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwPartID.Name = "iwPartID";
            this.iwPartID.Size = new System.Drawing.Size(201, 30);
            this.iwPartID.TabIndex = 21;
            // 
            // iwDatePanel
            // 
            this.iwDatePanel.Controls.Add(this.iwTo);
            this.iwDatePanel.Controls.Add(this.iwFrom);
            this.iwDatePanel.Controls.Add(this.label7);
            this.iwDatePanel.Controls.Add(this.label9);
            this.iwDatePanel.Enabled = false;
            this.iwDatePanel.Location = new System.Drawing.Point(25, 263);
            this.iwDatePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwDatePanel.Name = "iwDatePanel";
            this.iwDatePanel.Size = new System.Drawing.Size(341, 122);
            this.iwDatePanel.TabIndex = 16;
            this.iwDatePanel.Visible = false;
            // 
            // iwTo
            // 
            this.iwTo.CustomFormat = "yyyy-MM-dd";
            this.iwTo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwTo.Location = new System.Drawing.Point(86, 70);
            this.iwTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwTo.Name = "iwTo";
            this.iwTo.Size = new System.Drawing.Size(205, 30);
            this.iwTo.TabIndex = 3;
            this.iwTo.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // iwFrom
            // 
            this.iwFrom.CustomFormat = "yyyy-MM-dd";
            this.iwFrom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwFrom.Location = new System.Drawing.Point(86, 22);
            this.iwFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwFrom.Name = "iwFrom";
            this.iwFrom.Size = new System.Drawing.Size(205, 30);
            this.iwFrom.TabIndex = 2;
            this.iwFrom.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label9.Location = new System.Drawing.Point(18, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(22, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Part ID: ";
            // 
            // iwDate
            // 
            this.iwDate.AutoSize = true;
            this.iwDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwDate.Location = new System.Drawing.Point(35, 230);
            this.iwDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwDate.Name = "iwDate";
            this.iwDate.Size = new System.Drawing.Size(179, 26);
            this.iwDate.TabIndex = 15;
            this.iwDate.Text = "Querying by date?";
            this.iwDate.UseVisualStyleBackColor = true;
            this.iwDate.CheckedChanged += new System.EventHandler(this.iwDate_CheckedChanged);
            // 
            // iwSupplierID
            // 
            this.iwSupplierID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwSupplierID.FormattingEnabled = true;
            this.iwSupplierID.Location = new System.Drawing.Point(162, 100);
            this.iwSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwSupplierID.Name = "iwSupplierID";
            this.iwSupplierID.Size = new System.Drawing.Size(201, 30);
            this.iwSupplierID.TabIndex = 14;
            // 
            // iwID
            // 
            this.iwID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.iwID.FormattingEnabled = true;
            this.iwID.Location = new System.Drawing.Point(162, 32);
            this.iwID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iwID.Name = "iwID";
            this.iwID.Size = new System.Drawing.Size(201, 30);
            this.iwID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(22, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Supplier ID: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(22, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Inward ID: ";
            // 
            // orderStatus
            // 
            this.orderStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Location = new System.Drawing.Point(162, 163);
            this.orderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(201, 30);
            this.orderStatus.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(30, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Status: ";
            // 
            // invStatus
            // 
            this.invStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invStatus.FormattingEnabled = true;
            this.invStatus.Location = new System.Drawing.Point(161, 109);
            this.invStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invStatus.Name = "invStatus";
            this.invStatus.Size = new System.Drawing.Size(201, 30);
            this.invStatus.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(29, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 26);
            this.label14.TabIndex = 21;
            this.label14.Text = "Status: ";
            // 
            // didStatus
            // 
            this.didStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.didStatus.FormattingEnabled = true;
            this.didStatus.Location = new System.Drawing.Point(161, 158);
            this.didStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didStatus.Name = "didStatus";
            this.didStatus.Size = new System.Drawing.Size(201, 30);
            this.didStatus.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(29, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 26);
            this.label15.TabIndex = 22;
            this.label15.Text = "Status: ";
            // 
            // part
            // 
            this.part.Controls.Add(this.label19);
            this.part.Controls.Add(this.partPartName);
            this.part.Controls.Add(this.partCategory);
            this.part.Controls.Add(this.label18);
            this.part.Controls.Add(this.partStatus);
            this.part.Controls.Add(this.label16);
            this.part.Controls.Add(this.partPartID);
            this.part.Controls.Add(this.label17);
            this.part.Location = new System.Drawing.Point(9, 9);
            this.part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(400, 289);
            this.part.TabIndex = 23;
            this.part.Visible = false;
            // 
            // partStatus
            // 
            this.partStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.partStatus.FormattingEnabled = true;
            this.partStatus.Items.AddRange(new object[] {
            "Processing",
            "Assembled",
            "OStanding"});
            this.partStatus.Location = new System.Drawing.Point(163, 224);
            this.partStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partStatus.Name = "partStatus";
            this.partStatus.Size = new System.Drawing.Size(201, 30);
            this.partStatus.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(21, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 26);
            this.label16.TabIndex = 22;
            this.label16.Text = "Status: ";
            // 
            // partPartID
            // 
            this.partPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.partPartID.FormattingEnabled = true;
            this.partPartID.Location = new System.Drawing.Point(163, 29);
            this.partPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partPartID.Name = "partPartID";
            this.partPartID.Size = new System.Drawing.Size(201, 30);
            this.partPartID.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(21, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 26);
            this.label17.TabIndex = 16;
            this.label17.Text = "Part ID: ";
            // 
            // partCategory
            // 
            this.partCategory.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.partCategory.FormattingEnabled = true;
            this.partCategory.Location = new System.Drawing.Point(163, 162);
            this.partCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partCategory.Name = "partCategory";
            this.partCategory.Size = new System.Drawing.Size(201, 30);
            this.partCategory.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(21, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 26);
            this.label18.TabIndex = 23;
            this.label18.Text = "Category:  ";
            // 
            // partPartName
            // 
            this.partPartName.Location = new System.Drawing.Point(163, 98);
            this.partPartName.Name = "partPartName";
            this.partPartName.Size = new System.Drawing.Size(201, 29);
            this.partPartName.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(21, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 26);
            this.label19.TabIndex = 25;
            this.label19.Text = "Part Name: ";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2232, 1364);
            this.Controls.Add(this.part);
            this.Controls.Add(this.inward);
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
            this.invoice.ResumeLayout(false);
            this.invoice.PerformLayout();
            this.orderDateContainer.ResumeLayout(false);
            this.orderDateContainer.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.inward.ResumeLayout(false);
            this.inward.PerformLayout();
            this.iwDatePanel.ResumeLayout(false);
            this.iwDatePanel.PerformLayout();
            this.part.ResumeLayout(false);
            this.part.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox didPartID;
        private System.Windows.Forms.ComboBox didOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel invoice;
        private System.Windows.Forms.ComboBox invOrderID;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Panel inward;
        private System.Windows.Forms.Panel iwDatePanel;
        private System.Windows.Forms.DateTimePicker iwTo;
        private System.Windows.Forms.DateTimePicker iwFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox iwDate;
        private System.Windows.Forms.ComboBox iwSupplierID;
        private System.Windows.Forms.ComboBox iwID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox iwPartID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox invStatus;
        private System.Windows.Forms.ComboBox didStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel part;
        private System.Windows.Forms.ComboBox partCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox partStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox partPartID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox partPartName;
    }
}