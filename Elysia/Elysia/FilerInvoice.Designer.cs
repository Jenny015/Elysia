namespace Elysia
{
    partial class FilerInvoice
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
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.Order = new System.Windows.Forms.Panel();
            this.cbDealerID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOStatusA = new System.Windows.Forms.RadioButton();
            this.rbOStatusP = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DID = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbOStatusD = new System.Windows.Forms.RadioButton();
            this.Order.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DID.SuspendLayout();
            this.SuspendLayout();
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
            // Order
            // 
            this.Order.Controls.Add(this.cbDealerID);
            this.Order.Controls.Add(this.cbOrderID);
            this.Order.Controls.Add(this.label5);
            this.Order.Controls.Add(this.label3);
            this.Order.Controls.Add(this.groupBox1);
            this.Order.Location = new System.Drawing.Point(23, 52);
            this.Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(460, 290);
            this.Order.TabIndex = 12;
            this.Order.Visible = false;
            // 
            // cbDealerID
            // 
            this.cbDealerID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbDealerID.FormattingEnabled = true;
            this.cbDealerID.Location = new System.Drawing.Point(144, 94);
            this.cbDealerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDealerID.Name = "cbDealerID";
            this.cbDealerID.Size = new System.Drawing.Size(179, 27);
            this.cbDealerID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cope ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOStatusA);
            this.groupBox1.Controls.Add(this.rbOStatusP);
            this.groupBox1.Controls.Add(this.rbOStatusD);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Status";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbOStatusA
            // 
            this.rbOStatusA.AutoSize = true;
            this.rbOStatusA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusA.Location = new System.Drawing.Point(163, 37);
            this.rbOStatusA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusA.Name = "rbOStatusA";
            this.rbOStatusA.Size = new System.Drawing.Size(63, 23);
            this.rbOStatusA.TabIndex = 18;
            this.rbOStatusA.Text = "Send";
            this.rbOStatusA.UseVisualStyleBackColor = true;
            this.rbOStatusA.CheckedChanged += new System.EventHandler(this.rbOStatusA_CheckedChanged);
            // 
            // rbOStatusP
            // 
            this.rbOStatusP.AutoSize = true;
            this.rbOStatusP.Checked = true;
            this.rbOStatusP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusP.Location = new System.Drawing.Point(10, 37);
            this.rbOStatusP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusP.Name = "rbOStatusP";
            this.rbOStatusP.Size = new System.Drawing.Size(60, 23);
            this.rbOStatusP.TabIndex = 17;
            this.rbOStatusP.TabStop = true;
            this.rbOStatusP.Text = "Sign";
            this.rbOStatusP.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(167, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "DID filter";
            // 
            // DID
            // 
            this.DID.Controls.Add(this.label2);
            this.DID.Controls.Add(this.checkBox1);
            this.DID.Controls.Add(this.checkBox2);
            this.DID.Controls.Add(this.checkBox3);
            this.DID.Controls.Add(this.checkBox4);
            this.DID.Controls.Add(this.textBox1);
            this.DID.Controls.Add(this.textBox2);
            this.DID.Location = new System.Drawing.Point(23, 52);
            this.DID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(460, 292);
            this.DID.TabIndex = 11;
            this.DID.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 167);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(60, 215);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(219, 167);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(219, 215);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 25);
            this.textBox2.TabIndex = 1;
            // 
            // rbOStatusD
            // 
            this.rbOStatusD.AutoSize = true;
            this.rbOStatusD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbOStatusD.Location = new System.Drawing.Point(321, 37);
            this.rbOStatusD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOStatusD.Name = "rbOStatusD";
            this.rbOStatusD.Size = new System.Drawing.Size(62, 23);
            this.rbOStatusD.TabIndex = 14;
            this.rbOStatusD.Text = "Wait";
            this.rbOStatusD.UseVisualStyleBackColor = true;
            // 
            // FilerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 436);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DID);
            this.Name = "FilerInvoice";
            this.Text = "FilerInvoice";
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DID.ResumeLayout(false);
            this.DID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.Panel Order;
        private System.Windows.Forms.ComboBox cbDealerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOStatusA;
        private System.Windows.Forms.RadioButton rbOStatusP;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DID;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbOStatusD;
    }
}