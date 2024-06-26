namespace Elysia
{
    partial class ViewSupplierPart
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvSupplierPart = new System.Windows.Forms.DataGridView();
            this.sppID = new System.Windows.Forms.Label();
            this.sppt1 = new System.Windows.Forms.Label();
            this.spptCompany = new System.Windows.Forms.Label();
            this.sppt = new System.Windows.Forms.Label();
            this.spptAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierPart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 100);
            this.panel2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "View Supplier Part";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1324, 1097);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 44);
            this.btnFilter.TabIndex = 42;
            this.btnFilter.Text = "Add";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // dgvSupplierPart
            // 
            this.dgvSupplierPart.AllowUserToAddRows = false;
            this.dgvSupplierPart.AllowUserToDeleteRows = false;
            this.dgvSupplierPart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSupplierPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierPart.Location = new System.Drawing.Point(15, 253);
            this.dgvSupplierPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSupplierPart.Name = "dgvSupplierPart";
            this.dgvSupplierPart.RowHeadersWidth = 62;
            this.dgvSupplierPart.RowTemplate.Height = 31;
            this.dgvSupplierPart.Size = new System.Drawing.Size(1460, 818);
            this.dgvSupplierPart.TabIndex = 43;
            // 
            // sppID
            // 
            this.sppID.AutoSize = true;
            this.sppID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.sppID.Location = new System.Drawing.Point(269, 129);
            this.sppID.Name = "sppID";
            this.sppID.Size = new System.Drawing.Size(54, 33);
            this.sppID.TabIndex = 44;
            this.sppID.Text = "sID";
            // 
            // sppt1
            // 
            this.sppt1.AutoSize = true;
            this.sppt1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.sppt1.Location = new System.Drawing.Point(24, 129);
            this.sppt1.Name = "sppt1";
            this.sppt1.Size = new System.Drawing.Size(163, 32);
            this.sppt1.TabIndex = 45;
            this.sppt1.Text = "Supplier ID:";
            // 
            // spptCompany
            // 
            this.spptCompany.AutoSize = true;
            this.spptCompany.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.spptCompany.Location = new System.Drawing.Point(269, 201);
            this.spptCompany.Name = "spptCompany";
            this.spptCompany.Size = new System.Drawing.Size(79, 33);
            this.spptCompany.TabIndex = 46;
            this.spptCompany.Text = "sCom";
            // 
            // sppt
            // 
            this.sppt.AutoSize = true;
            this.sppt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.sppt.Location = new System.Drawing.Point(22, 202);
            this.sppt.Name = "sppt";
            this.sppt.Size = new System.Drawing.Size(249, 32);
            this.sppt.TabIndex = 47;
            this.sppt.Text = "Supplier Company:";
            // 
            // spptAddress
            // 
            this.spptAddress.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.spptAddress.Location = new System.Drawing.Point(1042, 129);
            this.spptAddress.Name = "spptAddress";
            this.spptAddress.Size = new System.Drawing.Size(432, 109);
            this.spptAddress.TabIndex = 48;
            this.spptAddress.Text = "sAddress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(797, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Supplier Address:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1149, 1097);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewSupplierPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.spptAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spptCompany);
            this.Controls.Add(this.sppt);
            this.Controls.Add(this.sppID);
            this.Controls.Add(this.sppt1);
            this.Controls.Add(this.dgvSupplierPart);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.panel2);
            this.Name = "ViewSupplierPart";
            this.Size = new System.Drawing.Size(1503, 1171);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvSupplierPart;
        private System.Windows.Forms.Label sppID;
        private System.Windows.Forms.Label sppt1;
        private System.Windows.Forms.Label spptCompany;
        private System.Windows.Forms.Label sppt;
        private System.Windows.Forms.Label spptAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
    }
}