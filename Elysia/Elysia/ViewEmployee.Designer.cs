namespace Elysia
{
    partial class ViewEmployee
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
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 90);
            this.panel2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "View Employee";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(1331, 996);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 41);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmp.ColumnHeadersHeight = 25;
            this.dgvEmp.Location = new System.Drawing.Point(21, 118);
            this.dgvEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.RowTemplate.Height = 27;
            this.dgvEmp.ShowEditingIcon = false;
            this.dgvEmp.Size = new System.Drawing.Size(1460, 850);
            this.dgvEmp.TabIndex = 47;
            this.dgvEmp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellEndEdit);
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewEmployee";
            this.Size = new System.Drawing.Size(1503, 1055);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvEmp;
    }
}