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
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOStatusD = new System.Windows.Forms.RadioButton();
            this.rbOStatusC = new System.Windows.Forms.RadioButton();
            this.rbOStatusO = new System.Windows.Forms.RadioButton();
            this.rbOStatusP = new System.Windows.Forms.RadioButton();
            this.rbOStatusA = new System.Windows.Forms.RadioButton();
            this.rbOStatusAll = new System.Windows.Forms.RadioButton();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbtnCancelled = new System.Windows.Forms.RadioButton();
            this.cbbtnOStanding = new System.Windows.Forms.RadioButton();
            this.cbbtnProcessing = new System.Windows.Forms.RadioButton();
            this.cbbtnAssembled = new System.Windows.Forms.RadioButton();
            this.cbbtnAllStatus = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDIDOrderID = new System.Windows.Forms.ComboBox();
            this.cbPartID = new System.Windows.Forms.ComboBox();
            this.DID = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.orderDateContainer.SuspendLayout();
            this.Order.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(175, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.rbOStatusD.CheckedChanged += new System.EventHandler(this.rbOStatusD_CheckedChanged);
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
            this.rbOStatusC.CheckedChanged += new System.EventHandler(this.rbOStatusC_CheckedChanged);
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
            this.rbOStatusO.CheckedChanged += new System.EventHandler(this.rbOStatusO_CheckedChanged);
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
            this.rbOStatusP.CheckedChanged += new System.EventHandler(this.rbOStatusP_CheckedChanged);
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
            this.rbOStatusA.CheckedChanged += new System.EventHandler(this.rbOStatusA_CheckedChanged);
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
            this.rbOStatusAll.CheckedChanged += new System.EventHandler(this.rbOStatusAll_CheckedChanged);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.cbOrderID.SelectedIndexChanged += new System.EventHandler(this.cbOrderID_SelectedIndexChanged);
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
            this.cbDealerID.SelectedIndexChanged += new System.EventHandler(this.cbDealerID_SelectedIndexChanged);
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
            this.orderDateContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.orderDateContainer_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.oDateFrom.ValueChanged += new System.EventHandler(this.oDateFrom_ValueChanged);
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
            this.oDateTo.ValueChanged += new System.EventHandler(this.oDateTo_ValueChanged);
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
            this.Order.Paint += new System.Windows.Forms.PaintEventHandler(this.Order_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbtnAllStatus);
            this.groupBox2.Controls.Add(this.cbbtnAssembled);
            this.groupBox2.Controls.Add(this.cbbtnProcessing);
            this.groupBox2.Controls.Add(this.cbbtnOStanding);
            this.groupBox2.Controls.Add(this.cbbtnCancelled);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(25, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(408, 122);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Status";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbbtnCancelled
            // 
            this.cbbtnCancelled.AutoSize = true;
            this.cbbtnCancelled.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbbtnCancelled.Location = new System.Drawing.Point(147, 78);
            this.cbbtnCancelled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtnCancelled.Name = "cbbtnCancelled";
            this.cbbtnCancelled.Size = new System.Drawing.Size(98, 23);
            this.cbbtnCancelled.TabIndex = 15;
            this.cbbtnCancelled.Text = "Cancelled";
            this.cbbtnCancelled.UseVisualStyleBackColor = true;
            this.cbbtnCancelled.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // cbbtnOStanding
            // 
            this.cbbtnOStanding.AutoSize = true;
            this.cbbtnOStanding.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbbtnOStanding.Location = new System.Drawing.Point(20, 78);
            this.cbbtnOStanding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtnOStanding.Name = "cbbtnOStanding";
            this.cbbtnOStanding.Size = new System.Drawing.Size(100, 23);
            this.cbbtnOStanding.TabIndex = 16;
            this.cbbtnOStanding.Text = "OStanding";
            this.cbbtnOStanding.UseVisualStyleBackColor = true;
            this.cbbtnOStanding.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // cbbtnProcessing
            // 
            this.cbbtnProcessing.AutoSize = true;
            this.cbbtnProcessing.Checked = true;
            this.cbbtnProcessing.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbbtnProcessing.Location = new System.Drawing.Point(20, 36);
            this.cbbtnProcessing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtnProcessing.Name = "cbbtnProcessing";
            this.cbbtnProcessing.Size = new System.Drawing.Size(106, 23);
            this.cbbtnProcessing.TabIndex = 17;
            this.cbbtnProcessing.TabStop = true;
            this.cbbtnProcessing.Text = "Processing";
            this.cbbtnProcessing.UseVisualStyleBackColor = true;
            this.cbbtnProcessing.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // cbbtnAssembled
            // 
            this.cbbtnAssembled.AutoSize = true;
            this.cbbtnAssembled.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbbtnAssembled.Location = new System.Drawing.Point(147, 36);
            this.cbbtnAssembled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtnAssembled.Name = "cbbtnAssembled";
            this.cbbtnAssembled.Size = new System.Drawing.Size(105, 23);
            this.cbbtnAssembled.TabIndex = 18;
            this.cbbtnAssembled.Text = "Assembled";
            this.cbbtnAssembled.UseVisualStyleBackColor = true;
            this.cbbtnAssembled.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbbtnAllStatus
            // 
            this.cbbtnAllStatus.AutoSize = true;
            this.cbbtnAllStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtnAllStatus.Location = new System.Drawing.Point(276, 61);
            this.cbbtnAllStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtnAllStatus.Name = "cbbtnAllStatus";
            this.cbbtnAllStatus.Size = new System.Drawing.Size(102, 23);
            this.cbbtnAllStatus.TabIndex = 19;
            this.cbbtnAllStatus.Text = "All Status";
            this.cbbtnAllStatus.UseVisualStyleBackColor = true;
            this.cbbtnAllStatus.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbDIDOrderID
            // 
            this.cbDIDOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDIDOrderID.FormattingEnabled = true;
            this.cbDIDOrderID.Location = new System.Drawing.Point(149, 27);
            this.cbDIDOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDIDOrderID.Name = "cbDIDOrderID";
            this.cbDIDOrderID.Size = new System.Drawing.Size(179, 27);
            this.cbDIDOrderID.TabIndex = 18;
            this.cbDIDOrderID.SelectedIndexChanged += new System.EventHandler(this.cbDIDOrderID_SelectedIndexChanged);
            // 
            // cbPartID
            // 
            this.cbPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(149, 82);
            this.cbPartID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(179, 27);
            this.cbPartID.TabIndex = 19;
            this.cbPartID.SelectedIndexChanged += new System.EventHandler(this.cbPartID_SelectedIndexChanged);
            // 
            // DID
            // 
            this.DID.Controls.Add(this.cbPartID);
            this.DID.Controls.Add(this.cbDIDOrderID);
            this.DID.Controls.Add(this.label2);
            this.DID.Controls.Add(this.label6);
            this.DID.Controls.Add(this.groupBox2);
            this.DID.Location = new System.Drawing.Point(9, 9);
            this.DID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(460, 292);
            this.DID.TabIndex = 6;
            this.DID.TabStop = true;
            this.DID.Visible = false;
            this.DID.Paint += new System.Windows.Forms.PaintEventHandler(this.DID_Paint);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 515);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filter";
            this.Text = "Filter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.orderDateContainer.ResumeLayout(false);
            this.orderDateContainer.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DID.ResumeLayout(false);
            this.DID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOStatusAll;
        private System.Windows.Forms.RadioButton rbOStatusA;
        private System.Windows.Forms.RadioButton rbOStatusP;
        private System.Windows.Forms.RadioButton rbOStatusO;
        private System.Windows.Forms.RadioButton rbOStatusC;
        private System.Windows.Forms.RadioButton rbOStatusD;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cbbtnAllStatus;
        private System.Windows.Forms.RadioButton cbbtnAssembled;
        private System.Windows.Forms.RadioButton cbbtnProcessing;
        private System.Windows.Forms.RadioButton cbbtnOStanding;
        private System.Windows.Forms.RadioButton cbbtnCancelled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDIDOrderID;
        private System.Windows.Forms.ComboBox cbPartID;
        private System.Windows.Forms.Panel DID;
    }
}