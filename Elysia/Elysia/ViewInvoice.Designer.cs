namespace Elysia
{
    partial class ViewInvoice
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
            this.isSide = new System.Windows.Forms.Panel();
            this.btnLD = new System.Windows.Forms.RadioButton();
            this.btnIG = new System.Windows.Forms.RadioButton();
            this.btnViewInvoice = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.isSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 75);
            this.panel2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "View Invoice";
            // 
            // isSide
            // 
            this.isSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(84)))), ((int)(((byte)(129)))));
            this.isSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isSide.Controls.Add(this.btnLD);
            this.isSide.Controls.Add(this.btnIG);
            this.isSide.Controls.Add(this.btnViewInvoice);
            this.isSide.Controls.Add(this.radioButton1);
            this.isSide.Controls.Add(this.btnLogout);
            this.isSide.Controls.Add(this.lblDept);
            this.isSide.Controls.Add(this.imgLogo);
            this.isSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.isSide.Location = new System.Drawing.Point(0, 0);
            this.isSide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isSide.Name = "isSide";
            this.isSide.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isSide.Size = new System.Drawing.Size(373, 796);
            this.isSide.TabIndex = 30;
            // 
            // btnLD
            // 
            this.btnLD.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLD.Location = new System.Drawing.Point(4, 413);
            this.btnLD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(363, 62);
            this.btnLD.TabIndex = 48;
            this.btnLD.TabStop = true;
            this.btnLD.Text = "Late Delivery";
            this.btnLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLD.UseVisualStyleBackColor = false;
            this.btnLD.Visible = false;
            // 
            // btnIG
            // 
            this.btnIG.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnIG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnIG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIG.Location = new System.Drawing.Point(4, 351);
            this.btnIG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIG.Name = "btnIG";
            this.btnIG.Size = new System.Drawing.Size(363, 62);
            this.btnIG.TabIndex = 47;
            this.btnIG.TabStop = true;
            this.btnIG.Text = "Invoice Generate";
            this.btnIG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIG.UseVisualStyleBackColor = false;
            this.btnIG.Visible = false;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.btnViewInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewInvoice.Location = new System.Drawing.Point(4, 289);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(363, 62);
            this.btnViewInvoice.TabIndex = 8;
            this.btnViewInvoice.TabStop = true;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewInvoice.UseVisualStyleBackColor = false;
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
            this.btnLogout.Location = new System.Drawing.Point(4, 741);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(363, 50);
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
            this.lblDept.Location = new System.Drawing.Point(4, 165);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(363, 62);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Invoicing Section";
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
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInv.ColumnHeadersHeight = 25;
            this.dgvInv.Location = new System.Drawing.Point(415, 100);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 27;
            this.dgvInv.ShowEditingIcon = false;
            this.dgvInv.Size = new System.Drawing.Size(1259, 597);
            this.dgvInv.TabIndex = 40;
            this.dgvInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInv_CellClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1541, 718);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(133, 34);
            this.btnFilter.TabIndex = 41;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 796);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.isSide);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewInvoice";
            this.Text = "ViewInvoice";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.isSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel isSide;
        private System.Windows.Forms.RadioButton btnViewInvoice;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnLogout;
        private System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.RadioButton btnLD;
        private System.Windows.Forms.RadioButton btnIG;
        private System.Windows.Forms.Button btnFilter;
    }
}