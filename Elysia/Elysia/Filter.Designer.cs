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
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOStatusAll = new System.Windows.Forms.RadioButton();
            this.rbOStatusA = new System.Windows.Forms.RadioButton();
            this.rbOStatusP = new System.Windows.Forms.RadioButton();
            this.rbOStatusO = new System.Windows.Forms.RadioButton();
            this.rbOStatusC = new System.Windows.Forms.RadioButton();
            this.rbOStatusD = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Panel();
            this.orderDateContainer = new System.Windows.Forms.Panel();
            this.oDateTo = new System.Windows.Forms.DateTimePicker();
            this.oDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.cbPartID = new System.Windows.Forms.ComboBox();
            this.cbDIDOrderID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.DID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Order.SuspendLayout();
            this.orderDateContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DID
            // 
            this.DID.Controls.Add(this.cbPartID);
            this.DID.Controls.Add(this.cbDIDOrderID);
            this.DID.Controls.Add(this.label2);
            this.DID.Controls.Add(this.label6);
            this.DID.Controls.Add(this.groupBox2);
            this.DID.Location = new System.Drawing.Point(7, 8);
            this.DID.Margin = new System.Windows.Forms.Padding(2);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(345, 253);
            this.DID.TabIndex = 6;
            this.DID.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(131, 404);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(306, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status";
            // 
            // rbOStatusAll
            // 
            this.rbOStatusAll.AutoSize = true;
            this.rbOStatusAll.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOStatusAll.Location = new System.Drawing.Point(207, 68);
            this.rbOStatusAll.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusAll.Name = "rbOStatusAll";
            this.rbOStatusAll.Size = new System.Drawing.Size(87, 21);
            this.rbOStatusAll.TabIndex = 19;
            this.rbOStatusAll.Text = "All Status";
            this.rbOStatusAll.UseVisualStyleBackColor = true;
            // 
            // rbOStatusA
            // 
            this.rbOStatusA.AutoSize = true;
            this.rbOStatusA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusA.Location = new System.Drawing.Point(110, 31);
            this.rbOStatusA.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusA.Name = "rbOStatusA";
            this.rbOStatusA.Size = new System.Drawing.Size(86, 20);
            this.rbOStatusA.TabIndex = 18;
            this.rbOStatusA.Text = "Assembled";
            this.rbOStatusA.UseVisualStyleBackColor = true;
            // 
            // rbOStatusP
            // 
            this.rbOStatusP.AutoSize = true;
            this.rbOStatusP.Checked = true;
            this.rbOStatusP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusP.Location = new System.Drawing.Point(15, 31);
            this.rbOStatusP.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusP.Name = "rbOStatusP";
            this.rbOStatusP.Size = new System.Drawing.Size(87, 20);
            this.rbOStatusP.TabIndex = 17;
            this.rbOStatusP.TabStop = true;
            this.rbOStatusP.Text = "Processing";
            this.rbOStatusP.UseVisualStyleBackColor = true;
            // 
            // rbOStatusO
            // 
            this.rbOStatusO.AutoSize = true;
            this.rbOStatusO.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusO.Location = new System.Drawing.Point(15, 68);
            this.rbOStatusO.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusO.Name = "rbOStatusO";
            this.rbOStatusO.Size = new System.Drawing.Size(84, 20);
            this.rbOStatusO.TabIndex = 16;
            this.rbOStatusO.Text = "OStanding";
            this.rbOStatusO.UseVisualStyleBackColor = true;
            // 
            // rbOStatusC
            // 
            this.rbOStatusC.AutoSize = true;
            this.rbOStatusC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusC.Location = new System.Drawing.Point(110, 68);
            this.rbOStatusC.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusC.Name = "rbOStatusC";
            this.rbOStatusC.Size = new System.Drawing.Size(79, 20);
            this.rbOStatusC.TabIndex = 15;
            this.rbOStatusC.Text = "Cancelled";
            this.rbOStatusC.UseVisualStyleBackColor = true;
            // 
            // rbOStatusD
            // 
            this.rbOStatusD.AutoSize = true;
            this.rbOStatusD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusD.Location = new System.Drawing.Point(207, 31);
            this.rbOStatusD.Margin = new System.Windows.Forms.Padding(2);
            this.rbOStatusD.Name = "rbOStatusD";
            this.rbOStatusD.Size = new System.Drawing.Size(91, 20);
            this.rbOStatusD.TabIndex = 14;
            this.rbOStatusD.Text = "Despatched";
            this.rbOStatusD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dealer ID: ";
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
            this.Order.Location = new System.Drawing.Point(7, 8);
            this.Order.Margin = new System.Windows.Forms.Padding(2);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(345, 383);
            this.Order.TabIndex = 7;
            this.Order.Visible = false;
            // 
            // orderDateContainer
            // 
            this.orderDateContainer.Controls.Add(this.oDateTo);
            this.orderDateContainer.Controls.Add(this.oDateFrom);
            this.orderDateContainer.Controls.Add(this.label4);
            this.orderDateContainer.Controls.Add(this.label1);
            this.orderDateContainer.Enabled = false;
            this.orderDateContainer.Location = new System.Drawing.Point(15, 282);
            this.orderDateContainer.Margin = new System.Windows.Forms.Padding(2);
            this.orderDateContainer.Name = "orderDateContainer";
            this.orderDateContainer.Size = new System.Drawing.Size(306, 88);
            this.orderDateContainer.TabIndex = 16;
            this.orderDateContainer.Visible = false;
            // 
            // oDateTo
            // 
            this.oDateTo.CustomFormat = "yyyy-MM-dd";
            this.oDateTo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateTo.Location = new System.Drawing.Point(57, 50);
            this.oDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.oDateTo.Name = "oDateTo";
            this.oDateTo.Size = new System.Drawing.Size(208, 23);
            this.oDateTo.TabIndex = 3;
            this.oDateTo.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // oDateFrom
            // 
            this.oDateFrom.CustomFormat = "yyyy-MM-dd";
            this.oDateFrom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.oDateFrom.Location = new System.Drawing.Point(57, 16);
            this.oDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.oDateFrom.Name = "oDateFrom";
            this.oDateFrom.Size = new System.Drawing.Size(208, 23);
            this.oDateFrom.TabIndex = 2;
            this.oDateFrom.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDate.Location = new System.Drawing.Point(22, 258);
            this.cbDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(129, 20);
            this.cbDate.TabIndex = 15;
            this.cbDate.Text = "Querying by date?";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // cbDealerID
            // 
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(108, 81);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(135, 23);
            this.cbDealerID.TabIndex = 14;
            // 
            // cbOrderID
            // 
            this.cbOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(108, 33);
            this.cbOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(135, 23);
            this.cbOrderID.TabIndex = 13;
            // 
            // cbPartID
            // 
            this.cbPartID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbPartID.FormattingEnabled = true;
            this.cbPartID.Location = new System.Drawing.Point(112, 71);
            this.cbPartID.Margin = new System.Windows.Forms.Padding(2);
            this.cbPartID.Name = "cbPartID";
            this.cbPartID.Size = new System.Drawing.Size(135, 23);
            this.cbPartID.TabIndex = 19;
            // 
            // cbDIDOrderID
            // 
            this.cbDIDOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDIDOrderID.FormattingEnabled = true;
            this.cbDIDOrderID.Location = new System.Drawing.Point(112, 23);
            this.cbDIDOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.cbDIDOrderID.Name = "cbDIDOrderID";
            this.cbDIDOrderID.Size = new System.Drawing.Size(135, 23);
            this.cbDIDOrderID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Part ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(19, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(306, 106);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Status";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(207, 53);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.Text = "All Status";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radioButton2.Location = new System.Drawing.Point(110, 31);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Assembled";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radioButton3.Location = new System.Drawing.Point(15, 31);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 20);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Processing";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radioButton4.Location = new System.Drawing.Point(15, 68);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 20);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.Text = "OStanding";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radioButton5.Location = new System.Drawing.Point(110, 68);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(79, 20);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.Text = "Cancelled";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(361, 446);
            this.Controls.Add(this.DID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Filter";
            this.Text = "Filter";
            this.DID.ResumeLayout(false);
            this.DID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.orderDateContainer.ResumeLayout(false);
            this.orderDateContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Order;
        private System.Windows.Forms.ComboBox cbDealerID;
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.RadioButton rbOStatusC;
        private System.Windows.Forms.RadioButton rbOStatusD;
        private System.Windows.Forms.RadioButton rbOStatusA;
        private System.Windows.Forms.RadioButton rbOStatusP;
        private System.Windows.Forms.RadioButton rbOStatusO;
        private System.Windows.Forms.RadioButton rbOStatusAll;
        private System.Windows.Forms.Panel orderDateContainer;
        private System.Windows.Forms.DateTimePicker oDateTo;
        private System.Windows.Forms.DateTimePicker oDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.ComboBox cbPartID;
        private System.Windows.Forms.ComboBox cbDIDOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}