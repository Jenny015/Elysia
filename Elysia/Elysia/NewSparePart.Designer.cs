namespace Elysia
{
    partial class NewSparePart
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPartID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.lbCompany = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.TextBox();
            this.lbDealerName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 90);
            this.panel2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Spare Part";
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblPartID.Location = new System.Drawing.Point(185, 226);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(61, 33);
            this.lblPartID.TabIndex = 71;
            this.lblPartID.Text = "N\\A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Part ID: ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(590, 854);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 42);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(812, 854);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 42);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // partPrice
            // 
            this.partPrice.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.partPrice.Location = new System.Drawing.Point(47, 568);
            this.partPrice.MaxLength = 10;
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(915, 40);
            this.partPrice.TabIndex = 61;
            this.partPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partPrice_KeyPress);
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbCompany.Location = new System.Drawing.Point(559, 226);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(123, 32);
            this.lbCompany.TabIndex = 58;
            this.lbCompany.Text = "Category";
            // 
            // partName
            // 
            this.partName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.partName.Location = new System.Drawing.Point(47, 391);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(915, 40);
            this.partName.TabIndex = 57;
            // 
            // lbDealerName
            // 
            this.lbDealerName.AutoSize = true;
            this.lbDealerName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbDealerName.Location = new System.Drawing.Point(41, 356);
            this.lbDealerName.Name = "lbDealerName";
            this.lbDealerName.Size = new System.Drawing.Size(142, 32);
            this.lbDealerName.TabIndex = 56;
            this.lbDealerName.Text = "Part Name";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbPhoneNumber.Location = new System.Drawing.Point(41, 533);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(165, 32);
            this.lbPhoneNumber.TabIndex = 60;
            this.lbPhoneNumber.Text = "Selling Price";
            // 
            // cate
            // 
            this.cate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cate.FormattingEnabled = true;
            this.cate.Location = new System.Drawing.Point(689, 223);
            this.cate.Name = "cate";
            this.cate.Size = new System.Drawing.Size(273, 41);
            this.cate.TabIndex = 72;
            this.cate.SelectedIndexChanged += new System.EventHandler(this.cate_SelectedIndexChanged);
            // 
            // NewSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cate);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.lbDealerName);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.panel2);
            this.Name = "NewSparePart";
            this.Size = new System.Drawing.Size(1503, 1055);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.Label lbDealerName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.ComboBox cate;
    }
}