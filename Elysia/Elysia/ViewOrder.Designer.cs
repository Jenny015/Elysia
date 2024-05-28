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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewOrder = new System.Windows.Forms.RadioButton();
            this.btnNewOrder = new System.Windows.Forms.RadioButton();
            this.btnViewDealer = new System.Windows.Forms.RadioButton();
            this.btnNewDealer = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Panel();
            this.OrderInfor = new System.Windows.Forms.Label();
            this.dataGridVieworder = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.btnNewOrder);
            this.panel1.Controls.Add(this.btnViewDealer);
            this.panel1.Controls.Add(this.btnNewDealer);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Size = new System.Drawing.Size(373, 804);
            this.panel1.TabIndex = 37;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrder.Location = new System.Drawing.Point(4, 475);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(363, 62);
            this.btnViewOrder.TabIndex = 11;
            this.btnViewOrder.TabStop = true;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewOrder.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOrder.Location = new System.Drawing.Point(4, 413);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(363, 62);
            this.btnNewOrder.TabIndex = 10;
            this.btnNewOrder.TabStop = true;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnViewDealer
            // 
            this.btnViewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDealer.Location = new System.Drawing.Point(4, 351);
            this.btnViewDealer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewDealer.Name = "btnViewDealer";
            this.btnViewDealer.Size = new System.Drawing.Size(363, 62);
            this.btnViewDealer.TabIndex = 9;
            this.btnViewDealer.TabStop = true;
            this.btnViewDealer.Text = "View Dealer";
            this.btnViewDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDealer.UseVisualStyleBackColor = false;
            // 
            // btnNewDealer
            // 
            this.btnNewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnNewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDealer.Location = new System.Drawing.Point(4, 289);
            this.btnNewDealer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(363, 62);
            this.btnNewDealer.TabIndex = 8;
            this.btnNewDealer.TabStop = true;
            this.btnNewDealer.Text = "New Dealer";
            this.btnNewDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewDealer.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(4, 227);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(363, 62);
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
            this.btnLogout.Location = new System.Drawing.Point(4, 750);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(363, 49);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(4, 165);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(363, 62);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Sales Office";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(4, 3);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(363, 162);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(418, -29);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(41, 15);
            this.lblOrderID.TabIndex = 36;
            this.lblOrderID.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(609, -29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "label1";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bar.Controls.Add(this.OrderInfor);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1710, 75);
            this.bar.TabIndex = 38;
            // 
            // OrderInfor
            // 
            this.OrderInfor.AutoSize = true;
            this.OrderInfor.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.OrderInfor.ForeColor = System.Drawing.Color.White;
            this.OrderInfor.Location = new System.Drawing.Point(36, 22);
            this.OrderInfor.Name = "OrderInfor";
            this.OrderInfor.Size = new System.Drawing.Size(309, 35);
            this.OrderInfor.TabIndex = 20;
            this.OrderInfor.Text = "Order Information";
            // 
            // dataGridVieworder
            // 
            this.dataGridVieworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVieworder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVieworder.ColumnHeadersHeight = 25;
            this.dataGridVieworder.Location = new System.Drawing.Point(414, 135);
            this.dataGridVieworder.Name = "dataGridVieworder";
            this.dataGridVieworder.RowHeadersWidth = 51;
            this.dataGridVieworder.RowTemplate.Height = 27;
            this.dataGridVieworder.Size = new System.Drawing.Size(1252, 643);
            this.dataGridVieworder.TabIndex = 39;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Plum;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1532, 836);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 34);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 879);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.dataGridVieworder);
            this.Controls.Add(this.btnSave);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnViewOrder;
        private System.Windows.Forms.RadioButton btnNewOrder;
        private System.Windows.Forms.RadioButton btnViewDealer;
        private System.Windows.Forms.RadioButton btnNewDealer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label OrderInfor;
        private System.Windows.Forms.DataGridView dataGridVieworder;
        private System.Windows.Forms.Button btnSave;
    }
}