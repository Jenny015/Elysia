namespace Elysia
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
            this.dataGridVieworder = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.Panel();
            this.OrderInfor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).BeginInit();
            this.bar.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel1.Size = new System.Drawing.Size(280, 690);
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
            this.btnViewOrder.Location = new System.Drawing.Point(3, 413);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(272, 54);
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
            this.btnNewOrder.Location = new System.Drawing.Point(3, 359);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(272, 54);
            this.btnNewOrder.TabIndex = 10;
            this.btnNewOrder.TabStop = true;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.CheckedChanged += new System.EventHandler(this.btnNewOrder_CheckedChanged);
            // 
            // btnViewDealer
            // 
            this.btnViewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDealer.Location = new System.Drawing.Point(3, 305);
            this.btnViewDealer.Name = "btnViewDealer";
            this.btnViewDealer.Size = new System.Drawing.Size(272, 54);
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
            this.btnNewDealer.Location = new System.Drawing.Point(3, 251);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(272, 54);
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
            this.radioButton1.Location = new System.Drawing.Point(3, 197);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(272, 54);
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
            this.btnLogout.Location = new System.Drawing.Point(3, 643);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(272, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.CheckedChanged += new System.EventHandler(this.btnLogout_CheckedChanged);
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(3, 143);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(272, 54);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Sales Office";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(272, 140);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(313, -25);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(35, 13);
            this.lblOrderID.TabIndex = 36;
            this.lblOrderID.Text = "label1";
            // 
            // dataGridVieworder
            // 
            this.dataGridVieworder.AllowUserToAddRows = false;
            this.dataGridVieworder.AllowUserToDeleteRows = false;
            this.dataGridVieworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVieworder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridVieworder.ColumnHeadersHeight = 25;
            this.dataGridVieworder.Location = new System.Drawing.Point(311, 117);
            this.dataGridVieworder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridVieworder.Name = "dataGridVieworder";
            this.dataGridVieworder.ReadOnly = true;
            this.dataGridVieworder.RowHeadersWidth = 51;
            this.dataGridVieworder.RowTemplate.Height = 27;
            this.dataGridVieworder.ShowEditingIcon = false;
            this.dataGridVieworder.Size = new System.Drawing.Size(939, 557);
            this.dataGridVieworder.TabIndex = 39;
            this.dataGridVieworder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieworder_CellClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1149, 708);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 29);
            this.btnFilter.TabIndex = 41;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.bar.Controls.Add(this.OrderInfor);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(280, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1003, 65);
            this.bar.TabIndex = 42;
            // 
            // OrderInfor
            // 
            this.OrderInfor.AutoSize = true;
            this.OrderInfor.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.OrderInfor.ForeColor = System.Drawing.Color.White;
            this.OrderInfor.Location = new System.Drawing.Point(27, 19);
            this.OrderInfor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderInfor.Name = "OrderInfor";
            this.OrderInfor.Size = new System.Drawing.Size(245, 29);
            this.OrderInfor.TabIndex = 20;
            this.OrderInfor.Text = "Order Information";
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dataGridVieworder);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworder)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridVieworder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label OrderInfor;
    }
}