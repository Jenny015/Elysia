namespace Elysia
{
    partial class ViewDID
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
            this.btnLogout = new System.Windows.Forms.RadioButton();
            this.btnViewOrder = new System.Windows.Forms.RadioButton();
            this.btnNewOrder = new System.Windows.Forms.RadioButton();
            this.btnDID = new System.Windows.Forms.RadioButton();
            this.btnNewDealer = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDID = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.btnNewOrder);
            this.panel1.Controls.Add(this.btnDID);
            this.panel1.Controls.Add(this.btnNewDealer);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(419, 1172);
            this.panel1.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(4, 1099);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(409, 66);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.CheckedChanged += new System.EventHandler(this.btnLogout_CheckedChanged);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrder.Location = new System.Drawing.Point(4, 552);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(409, 83);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.TabStop = true;
            this.btnViewOrder.Text = "Late Delivery";
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
            this.btnNewOrder.Location = new System.Drawing.Point(4, 469);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(409, 83);
            this.btnNewOrder.TabIndex = 4;
            this.btnNewOrder.TabStop = true;
            this.btnNewOrder.Text = "Spare Part";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnDID
            // 
            this.btnDID.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnDID.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDID.Location = new System.Drawing.Point(4, 386);
            this.btnDID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDID.Name = "btnDID";
            this.btnDID.Size = new System.Drawing.Size(409, 83);
            this.btnDID.TabIndex = 3;
            this.btnDID.TabStop = true;
            this.btnDID.Text = "DID";
            this.btnDID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDID.UseVisualStyleBackColor = false;
            // 
            // btnNewDealer
            // 
            this.btnNewDealer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnNewDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewDealer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewDealer.Location = new System.Drawing.Point(4, 303);
            this.btnNewDealer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(409, 83);
            this.btnNewDealer.TabIndex = 2;
            this.btnNewDealer.TabStop = true;
            this.btnNewDealer.Text = "User";
            this.btnNewDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewDealer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewDealer.UseVisualStyleBackColor = false;
            // 
            // lblDept
            // 
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblDept.Location = new System.Drawing.Point(4, 220);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(409, 83);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Storemen";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(4, 5);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(409, 215);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 100);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(787, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Order Processing System (Assemble DID)";
            // 
            // dgvDID
            // 
            this.dgvDID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDID.Location = new System.Drawing.Point(439, 126);
            this.dgvDID.Name = "dgvDID";
            this.dgvDID.RowHeadersWidth = 62;
            this.dgvDID.RowTemplate.Height = 31;
            this.dgvDID.Size = new System.Drawing.Size(1459, 969);
            this.dgvDID.TabIndex = 26;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1748, 1113);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 45);
            this.btnFilter.TabIndex = 34;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ViewDID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1172);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvDID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDID";
            this.Text = "viewDID";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.RadioButton btnViewOrder;
        private System.Windows.Forms.RadioButton btnNewOrder;
        private System.Windows.Forms.RadioButton btnDID;
        private System.Windows.Forms.RadioButton btnNewDealer;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDID;
        private System.Windows.Forms.Button btnFilter;
    }
}