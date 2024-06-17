﻿namespace Elysia
{
    partial class ViewOrder
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
            this.dataGridVieworder = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Panel();
            this.compName = new System.Windows.Forms.Label();
            this.InvPreview = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblDPhone = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.lblDCom = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.BOrderID = new System.Windows.Forms.Label();
            this.BDAddr = new System.Windows.Forms.Label();
            this.BDPhone = new System.Windows.Forms.Label();
            this.BDCom = new System.Windows.Forms.Label();
            this.BDName = new System.Windows.Forms.Label();
            this.BOrderDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).BeginInit();
            this.panel2.SuspendLayout();
            this.heading.SuspendLayout();
            this.InvPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVieworder
            // 
            this.dataGridVieworder.AllowUserToAddRows = false;
            this.dataGridVieworder.AllowUserToDeleteRows = false;
            this.dataGridVieworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVieworder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVieworder.ColumnHeadersHeight = 25;
            this.dataGridVieworder.Location = new System.Drawing.Point(22, 116);
            this.dataGridVieworder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridVieworder.Name = "dataGridVieworder";
            this.dataGridVieworder.ReadOnly = true;
            this.dataGridVieworder.RowHeadersWidth = 51;
            this.dataGridVieworder.RowTemplate.Height = 27;
            this.dataGridVieworder.ShowEditingIcon = false;
            this.dataGridVieworder.Size = new System.Drawing.Size(1460, 850);
            this.dataGridVieworder.TabIndex = 39;
            this.dataGridVieworder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieworder_CellClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1332, 994);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 40);
            this.btnFilter.TabIndex = 41;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 90);
            this.panel2.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "ViewOrder";
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.White;
            this.heading.Controls.Add(this.compName);
            this.heading.Location = new System.Drawing.Point(10, 116);
            this.heading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1482, 76);
            this.heading.TabIndex = 60;
            this.heading.Visible = false;
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.compName.Location = new System.Drawing.Point(431, 18);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(552, 32);
            this.compName.TabIndex = 1;
            this.compName.Text = "Legend Motor (LC) Limited Company";
            // 
            // InvPreview
            // 
            this.InvPreview.BackColor = System.Drawing.Color.White;
            this.InvPreview.Controls.Add(this.dgv);
            this.InvPreview.Controls.Add(this.lblAddr);
            this.InvPreview.Controls.Add(this.lblDPhone);
            this.InvPreview.Controls.Add(this.lblDName);
            this.InvPreview.Controls.Add(this.lblDCom);
            this.InvPreview.Controls.Add(this.lblOrderDate);
            this.InvPreview.Controls.Add(this.lblOrderID);
            this.InvPreview.Controls.Add(this.BOrderID);
            this.InvPreview.Controls.Add(this.BDAddr);
            this.InvPreview.Controls.Add(this.BDPhone);
            this.InvPreview.Controls.Add(this.BDCom);
            this.InvPreview.Controls.Add(this.BDName);
            this.InvPreview.Controls.Add(this.BOrderDate);
            this.InvPreview.Location = new System.Drawing.Point(10, 196);
            this.InvPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InvPreview.Name = "InvPreview";
            this.InvPreview.Size = new System.Drawing.Size(1482, 770);
            this.InvPreview.TabIndex = 59;
            this.InvPreview.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 90);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(1448, 657);
            this.dgv.TabIndex = 0;
            // 
            // lblAddr
            // 
            this.lblAddr.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblAddr.Location = new System.Drawing.Point(870, 41);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(597, 47);
            this.lblAddr.TabIndex = 37;
            this.lblAddr.Text = "label18";
            // 
            // lblDPhone
            // 
            this.lblDPhone.AutoSize = true;
            this.lblDPhone.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDPhone.Location = new System.Drawing.Point(1201, 7);
            this.lblDPhone.Name = "lblDPhone";
            this.lblDPhone.Size = new System.Drawing.Size(70, 22);
            this.lblDPhone.TabIndex = 36;
            this.lblDPhone.Text = "label18";
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDName.Location = new System.Drawing.Point(870, 7);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(70, 22);
            this.lblDName.TabIndex = 35;
            this.lblDName.Text = "label18";
            // 
            // lblDCom
            // 
            this.lblDCom.AutoSize = true;
            this.lblDCom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDCom.Location = new System.Drawing.Point(176, 38);
            this.lblDCom.Name = "lblDCom";
            this.lblDCom.Size = new System.Drawing.Size(70, 22);
            this.lblDCom.TabIndex = 33;
            this.lblDCom.Text = "label18";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(507, 5);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(70, 22);
            this.lblOrderDate.TabIndex = 31;
            this.lblOrderDate.Text = "label18";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOrderID.Location = new System.Drawing.Point(176, 5);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 22);
            this.lblOrderID.TabIndex = 30;
            this.lblOrderID.Text = "label18";
            // 
            // BOrderID
            // 
            this.BOrderID.AutoSize = true;
            this.BOrderID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderID.Location = new System.Drawing.Point(15, 5);
            this.BOrderID.Name = "BOrderID";
            this.BOrderID.Size = new System.Drawing.Size(100, 23);
            this.BOrderID.TabIndex = 20;
            this.BOrderID.Text = "Order ID: ";
            // 
            // BDAddr
            // 
            this.BDAddr.AutoSize = true;
            this.BDAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDAddr.Location = new System.Drawing.Point(709, 38);
            this.BDAddr.Name = "BDAddr";
            this.BDAddr.Size = new System.Drawing.Size(166, 23);
            this.BDAddr.TabIndex = 26;
            this.BDAddr.Text = "Delivery Address: ";
            // 
            // BDPhone
            // 
            this.BDPhone.AutoSize = true;
            this.BDPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDPhone.Location = new System.Drawing.Point(1070, 5);
            this.BDPhone.Name = "BDPhone";
            this.BDPhone.Size = new System.Drawing.Size(136, 23);
            this.BDPhone.TabIndex = 25;
            this.BDPhone.Text = "Dealer Phone: ";
            // 
            // BDCom
            // 
            this.BDCom.AutoSize = true;
            this.BDCom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDCom.Location = new System.Drawing.Point(15, 37);
            this.BDCom.Name = "BDCom";
            this.BDCom.Size = new System.Drawing.Size(163, 23);
            this.BDCom.TabIndex = 21;
            this.BDCom.Text = "Dealer Company: ";
            // 
            // BDName
            // 
            this.BDName.AutoSize = true;
            this.BDName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BDName.Location = new System.Drawing.Point(709, 5);
            this.BDName.Name = "BDName";
            this.BDName.Size = new System.Drawing.Size(133, 23);
            this.BDName.TabIndex = 23;
            this.BDName.Text = "Dealer Name: ";
            // 
            // BOrderDate
            // 
            this.BOrderDate.AutoSize = true;
            this.BOrderDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.BOrderDate.Location = new System.Drawing.Point(376, 4);
            this.BOrderDate.Name = "BOrderDate";
            this.BOrderDate.Size = new System.Drawing.Size(120, 23);
            this.BOrderDate.TabIndex = 22;
            this.BOrderDate.Text = "Order Date: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1332, 994);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.InvPreview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridVieworder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(1503, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.InvPreview.ResumeLayout(false);
            this.InvPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridVieworder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Label compName;
        private System.Windows.Forms.Panel InvPreview;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblDPhone;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblDCom;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label BOrderID;
        private System.Windows.Forms.Label BDAddr;
        private System.Windows.Forms.Label BDPhone;
        private System.Windows.Forms.Label BDCom;
        private System.Windows.Forms.Label BDName;
        private System.Windows.Forms.Label BOrderDate;
        private System.Windows.Forms.Button btnBack;
    }
}